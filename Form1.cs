// Created by Mike Tucker
// mtucker6784@gmail.com
// Provided under GPL 3.0 @ http://www.gnu.org/licenses/gpl.html
// For LDAP, add System.DirectoryServices.AccountManagement reference

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using System.Security.Cryptography.X509Certificates;
using System.DirectoryServices.AccountManagement;
using Google.Apis.Download;
using System.Configuration;
using System.IO;
namespace TuckerTech_GABackup_GUI
{

    public partial class Form1 : Form
    {
        // Google wanted me to define these.
        static string[] Scopes = { DriveService.Scope.DriveReadonly };
        static string ApplicationName = "Drive API .NET Quickstart";
        CreateService service = new CreateService();

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abt = new AboutBox1();
            abt.Show();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences pref = new Preferences();
            pref.Show();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "User text file (*.txt)|*.txt";
                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtFile.Text = ofd.FileName;
                }
                else
                {
                    stripLabel.Text = "Browse Canceled!";
                }
            }
            catch (Exception ex)
            {
                stripLabel.Text = ex.Message.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            if (bgW.IsBusy == true)
            {
                proBar1.Value = 0;
                txtFile.Enabled = true;
                proBar1.Visible = false;
                bgW.CancelAsync();
                bgLDAP.CancelAsync();
                btnStart.Text = "Start Backup";
                chkLDAP.Enabled = true;
            }
            else
            {
                if (txtFile.Text == "ldapusers.txt")
                {
                    btnStart.Text = "Cancel Backup";
                    bgW.RunWorkerAsync();
                }
                else if (chkLDAP.Checked == true)
                {
                    btnStart.Text = "Cancel Backup";
                    bgLDAP.RunWorkerAsync();
                }
                else
                    btnStart.Text = "Cancel Backup";
                bgW.RunWorkerAsync();
            }
        }

        private void bgW_DoWork(object sender, DoWorkEventArgs e)
        {

            {
                try
                {
                    chkLDAP.Enabled = false;
                    txtFile.ReadOnly = true;
                    btnStart.Text = "Cancel Backup";
                    CheckForIllegalCrossThreadCalls = false;
                    var appSettings = ConfigurationManager.AppSettings;
                    string checkreplace = ConfigurationManager.AppSettings["checkreplace"];
                    string userfile = txtFile.Text;
                    int counter = 0;
                    proBar1.Visible = true;
                    // Take a peek inside our users file!
                    // enumerate through each domain account and check for changed
                    // or new files.

                    if (userfile.Length >= 1)
                    {
                        if (bgW.CancellationPending)
                        {
                            e.Cancel = true;
                            stripLabel.Text = "Operation was canceled!";
                            return;
                        }
                        string[] users = File.ReadAllLines(userfile);


                        for (int z = 0; z >= counter; z++)
                        {
                            if (bgW.CancellationPending)
                            {
                                e.Cancel = true;
                                stripLabel.Text = "Operation was canceled!";
                                return;
                            }
                            string names = users[z];
                            if (users != null)
                            {
                                try
                                {
                                    proBar1.Visible = true;
                                    stripLabel.Text = "";
                                    Console.WriteLine("Selecting user: " + names.ToString());
                                    txtLog.Text += ("Selecting user: " + names.ToString() + Environment.NewLine);
                                    txtCurrentUser.Text = names.ToString();
                                    // Define parameters of request.
                                    int counter1 = 0;
                                    string user = names.ToString();
                                    // Check if directory exists, create if not.
                                    string savelocation = ConfigurationManager.AppSettings["savelocation"] + user + "\\";
                                    FileInfo testdir = new FileInfo(savelocation);
                                    //Console.WriteLine("New directory created at: " + testdir);
                                    testdir.Directory.Create();
                                    string savedStartPageToken = "";
                                    var start = CreateService.BuildService(user).Changes.GetStartPageToken().Execute();
                                    StreamWriter logFile = new StreamWriter(savelocation + ".recent.log");
                                    
                                    // This token is set by Google, it defines changes made and
                                    // increments the token value automatically. 
                                    // The following reads the current token file (if it exists)
                                    if (File.Exists(savelocation + ".currenttoken.tok"))
                                    {
                                        StreamReader curtokenfile = new StreamReader(savelocation + ".currenttoken.tok");
                                        savedStartPageToken = curtokenfile.ReadLine().ToString();
                                        curtokenfile.Close();
                                        curtokenfile.Dispose();
                                    }
                                    else
                                    {
                                        // Token record didn't exist. Create a generic file, start at "1st" token
                                        // In reality, I have no idea what token to start at, but 1 seems to be safe.
                                        Console.Write("Creating new token file.\n");
                                        txtLog.Text += ("Creating new token file.\n" + Environment.NewLine);
                                        StreamWriter sw = new StreamWriter(savelocation + ".currenttoken.tok");
                                        sw.Write(1);
                                        sw.Close();
                                        sw.Dispose();
                                        savedStartPageToken = "1";
                                    }
                                    proBar1.Value = 0;
                                    Console.WriteLine("Previous user token: " + savedStartPageToken);
                                    txtLog.Text += ("Previous user token: " + savedStartPageToken + Environment.NewLine);
                                    Console.WriteLine("My brand new token --->: " + start.StartPageTokenValue);
                                    txtLog.Text += ("Current user token: " + start.StartPageTokenValue + Environment.NewLine);
                                    Console.Write("Logging into your Gapps domain as: " + user + "\nChecking for any existing files...\nPlease wait as this may take a while.\n");
                                    txtLog.Text += ("Now logging into your Gapps domain as: " + user + Environment.NewLine + "Please wait as this may take a while." + Environment.NewLine);
                                    proBar1.Value = 0;
                                    string pageToken = savedStartPageToken;
                                    int gtoken = int.Parse(start.StartPageTokenValue);
                                    int mytoken = int.Parse(savedStartPageToken);
                                    txtPrevToken.Text = pageToken.ToString();
                                    txtCurrentToken.Text = gtoken.ToString();

                                    if (gtoken <= 10)
                                    {
                                        Console.WriteLine("Nothing to save!\n");
                                        txtLog.Text += ("User has nothing to save!" + Environment.NewLine);
                                    }
                                    else
                                    {
                                        if (pageToken == start.StartPageTokenValue)
                                        {
                                            Console.WriteLine("No file changes found for " + user + "\n");
                                            txtLog.Text += ("No file changes found! Please wait while I tidy up." + Environment.NewLine);
                                        }
                                        else
                                        {
                                            // .deltalog.tok is where we will place our records for changed files
                                            Console.WriteLine("Changes detected. Making notes while we go through these.");
                                            if (File.Exists(savelocation + ".deltalog.tok"))
                                                File.Delete(savelocation + ".deltalog.tok");
                                            lblProgresslbl.Text = "Scanning Drive directory.";
                                            using (StreamWriter deltalog = new StreamWriter(savelocation + ".deltalog.tok", true))
                                            {
                                                StreamWriter folderlog = new StreamWriter(savelocation + "folderlog.txt", true);
                                                while (pageToken != null)
                                                {
                                                    counter1++;
                                                    var request = CreateService.BuildService(user).Changes.List(pageToken);

                                                    request.Spaces = "drive";
                                                    request.Fields = "*";

                                                    DateTime dt = DateTime.Now;

                                                    var changes = request.Execute();

                                                        foreach (var change in changes.Changes)
                                                    {
                                                        if (bgW.CancellationPending)
                                                        {
                                                            e.Cancel = true;
                                                            stripLabel.Text = "Operation was canceled!";
                                                            return;
                                                        }
                                                        try
                                                        {

                                                            string updatedfile = change.File.Name;
                                                            string mimetype = change.File.MimeType;
                                                            string folderid = String.Join(",", change.File.Parents);
                                                            string dirname = (savelocation + updatedfile + "\\");
                                                            FileInfo newdir = new FileInfo(dirname);
                                                            
                                                            // If it's a folder, let's create it now so we can move files into it later.
                                                            if (mimetype == "application/vnd.google-apps.folder")
                                                            {
                                                                newdir.Directory.Create();
                                                                logFile.WriteLine("Directory " + dirname + " was successfully created!");
                                                                Console.WriteLine("Directory " + dirname + " was successfully created!\n");
                                                                folderlog.WriteLine(change.FileId + "," + dirname);
                                                                folderlog.Flush();
                                                            }
                                                            else
                                                            {
                                                                // Record the changed file
                                                                Console.WriteLine(user + ": New or changed file found: " + updatedfile + "\n");
                                                                logFile.WriteLine(user + ": New or changed file found: " + change.FileId + " --- " + updatedfile);
                                                                txtLog.Text += (user + ": New or changed file found: --- " + updatedfile + " Type: " + mimetype + Environment.NewLine);
                                                                deltalog.WriteLine(change.FileId + "," + updatedfile + "," + mimetype + "," + folderid);
                                                                deltalog.Flush();
                                                            }
                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            // Google seems to track every file ever created for the user
                                                            // it also keeps a record of the fileId. Even if a user
                                                            // deletes the file, it's still retained in Google's record
                                                            // although the file is no longer available.
                                                            // We'll throw an error to the user so the program will continue forth.
                                                            if (ex.Message.ToString().Contains("404"))
                                                            {
                                                                Console.WriteLine(user + ": 404 error. Selected record no longer exists.");
                                                                logFile.WriteLine(user + ": 404 error. Selected record no longer exists.");
                                                                txtLog.Text += (user + ": 404 error. Selected record no longer exists. Possibly old file that was renamed or removed by the user." + Environment.NewLine);
                                                            }
                                                            else
                                                            {
                                                                //Console.WriteLine(user + ": Verbatim error: " + ex.Message.ToString() + "\n");
                                                                logFile.WriteLine(user + ": Verbatim error: " + ex.Message.ToString() + "\n");
                                                                //txtLog.Text += (user + ": Verbatim error: " + ex.Message.ToString() + "\n" + Environment.NewLine);
                                                               
                                                            }

                                                        }

                                                    }
                                                    if (changes.NewStartPageToken != null)
                                                    {
                                                        // Last page, save this token for the next polling interval
                                                        savedStartPageToken = changes.NewStartPageToken;
                                                    }
                                                    // Bring our token up to date for next run
                                                    pageToken = changes.NextPageToken;
                                                    File.WriteAllText(savelocation + ".currenttoken.tok", start.StartPageTokenValue);
                                                      
                                                }
                                                deltalog.Close();
                                                folderlog.Close();
                                            }

                                            // Get all our files for the user. Max page size is 1k
                                            // after that, we have to use Google's next page token
                                            // to let us get more files.
                                            FilesResource.ListRequest listRequest = CreateService.BuildService(user).Files.List();
                                            listRequest.PageSize = 1000;
                                            listRequest.Fields = "nextPageToken, files(id, name)";
                                            string[] deltafiles = File.ReadAllLines(savelocation + ".deltalog.tok");
                                            int totalfiles = deltafiles.Count();
                                            int cnttototal = 0;
                                            proBar1.Maximum = totalfiles;

                                            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute()
                                                .Files;
                                            Console.WriteLine("\nFiles to backup:\n");
                                            txtLog.Text += (Environment.NewLine + "Files to backup:" + Environment.NewLine);
                                            if (deltafiles == null)
                                            {
                                                return;
                                            }
                                            else
                                            {

                                                foreach (var file in deltafiles)
                                                {
                                                    try
                                                    {
                                                        if (bgW.CancellationPending)
                                                        {
                                                            stripLabel.Text = "Backup canceled!";
                                                            e.Cancel = true;
                                                            break;
                                                        }
                                                        DateTime dt = DateTime.Now;
                                                        string[] foldervalues = File.ReadAllLines(savelocation + "folderlog.txt");

                                                        cnttototal++;
                                                        bgW.ReportProgress(cnttototal);
                                                        stripLabel.Text = "File " + cnttototal + " of " + totalfiles;
                                                        double mathisfun = ((100 * cnttototal) / totalfiles);
                                                        lblProgresslbl.Text = ("Current progress: " + mathisfun.ToString() +"% completed.");
                                                        //if (cnttototal == totalfiles)
                                                        //    stripLabel.Text = cnttototal + "/" + totalfiles + "!";
                                                        // Our file is a CSV. Column 1 = file ID, Column 2 = File name
                                                        var values = file.Split(',');

                                                        string fileId = values[0];
                                                        string fileName = values[1];
                                                        string mimetype = values[2];
                                                        string folder = values[3];
                                                        int foundmatch = 0;
                                                        int folderfilelen = foldervalues.Count();

                                                        fileName = fileName.Replace('\\', '_').Replace('/', '_').Replace(':', '_').Replace('!', '_').Replace('\'', '_').Replace('*', '_').Replace('#', '_').Replace('[', '_').Replace(']', '_');
                                                        Console.WriteLine("Filename: " + values[1]);
                                                        txtLog.Text += (Environment.NewLine + "Timestamp: " + dt.ToString() + " Filename: " + values[1]);
                                                        logFile.WriteLine("ID: " + values[0] + " - Filename: " + values[1]);
                                                        var requestfileid = CreateService.BuildService(user).Files.Get(fileId);
                                                        //requestfileid.Fields = "*";
                                                        //var folderidexec = requestfileid.Execute();
                                                        //var folderid = string.Join(",", folderidexec.Parents);

                                                        var request = CreateService.BuildService(user).Files.Export(fileId, mimetype);

                                                        //Default extensions for files. Not sure what this should be, so we'll null it for now.
                                                        string ext = null;


                                                        // Things get sloppy here. The reason we're checking MimeTypes
                                                        // is because we have to export the files from Google's format
                                                        // to a format that is readable by a desktop computer program
                                                        // So for example, the google-apps.spreadsheet will become an MS Excel file.
                                                        if (mimetype == "application/vnd.google-apps.spreadsheet" || mimetype == "application/vnd.google-apps.ritz" || mimetype == "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                                                        {
                                                            request = CreateService.BuildService(user).Files.Export(fileId, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                                                            ext = ".xls";
                                                        }
                                                        if (mimetype == "application/vnd.google-apps.document" || mimetype == "application/vnd.google-apps.kix")
                                                        {
                                                            request = CreateService.BuildService(user).Files.Export(fileId, "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
                                                            ext = ".docx";
                                                        }
                                                        if (mimetype == "application/vnd.google-apps.presentation" || mimetype == "application/vnd.google-apps.punch")
                                                        {
                                                            request = CreateService.BuildService(user).Files.Export(fileId, "application/vnd.openxmlformats-officedocument.presentationml.presentation");
                                                            ext = ".ppt";
                                                        }

                                                        // Google's folders are really just mime file types. Check for the file type
                                                        // grab the name of the file, and create it as such on the server FS.
                                                        lblFile.Text = (savelocation + fileName + ext);
                                                        if (mimetype == "application/vnd.google-apps.folder")
                                                        {
                                                            throw new Exception("This is a folder which already exists. Skipping.");
                                                        }
                                                        else
                                                        {

                                                            // Again, things get a little sloppy. Let's find if these files match any of the types in our IF statement.
                                                            if (mimetype == "image/gif" || mimetype == "image/jpeg" || mimetype == "image/png" || mimetype == "text/plain" || mimetype == "application/pdf" || mimetype == "application/vnd.google-apps.drawing" || mimetype == "application/vnd.google-apps.form")
                                                            {
                                                                if (mimetype == "application/pdf")
                                                                {
                                                                    throw new Exception("PDF files not supported right now as they tend to hang the backup.");
                                                                }
                                                                Console.Write("MIME Type update: " + mimetype);
                                                                txtLog.Text += (Environment.NewLine + "MIME Type update: " + mimetype + Environment.NewLine);
                                                                logFile.WriteLine(fileName + " MIME Type ---> " + mimetype + "\n");
                                                                string dest1 = Path.Combine(savelocation, fileName);
                                                                var stream1 = new System.IO.FileStream(dest1, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                                                                lblFile.Text = (savelocation + fileName + ext);
                                                                // Add a handler which will be notified on progress changes.
                                                                // It will notify on each chunk download and when the
                                                                // download is completed or failed.
                                                                requestfileid.MediaDownloader.ProgressChanged +=
                                                                        (IDownloadProgress progress) =>
                                                                        {
                                                                            switch (progress.Status)
                                                                            {
                                                                                case DownloadStatus.Downloading:
                                                                                    {

                                                                                        txtLog.Text += (progress.BytesDownloaded);
                                                                                        break;
                                                                                    }
                                                                                case DownloadStatus.Completed:
                                                                                    {
                                                                                        Console.WriteLine("Download complete.");
                                                                                        logFile.WriteLine(fileName + " downloaded successfully.\n");
                                                                                        break;
                                                                                    }
                                                                                case DownloadStatus.Failed:
                                                                                    {
                                                                                        Console.WriteLine("Error: There is nothing I can do with this file\n Is this is a draw or form?");
                                                                                        txtLog.Text += (Environment.NewLine + "Error: There is nothing I can do with this file\n Is this is a draw or form?" + Environment.NewLine);
                                                                                        logFile.WriteLine(fileName + " could not be downloaded. Possible Google draw/form OR bad name.\n");
                                                                                        break;
                                                                                    }
                                                                            }
                                                                        };
                                                                requestfileid.Download(stream1);
                                                                stream1.Close();
                                                                stream1.Dispose();
                                                            }
                                                            else
                                                            {
                                                                // Any other file type, assume as know what it is (which in our case, will be a txt file)
                                                                // apply the mime type and carry on.
                                                                logFile.WriteLine(fileName + " MIME Type ---> " + mimetype + "\n");
                                                                string dest = Path.Combine(savelocation, fileName + ext);
                                                                var stream = new System.IO.FileStream(dest, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                                                                int oops = 0;
                                                                // Add a handler which will be notified on progress changes.
                                                                // It will notify on each chunk download and when the
                                                                // download is completed or failed.
                                                                request.MediaDownloader.ProgressChanged +=
                                                                    (IDownloadProgress progress) =>
                                                                    {
                                                                        switch (progress.Status)
                                                                        {
                                                                            case DownloadStatus.Downloading:
                                                                                {
                                                                                    txtLog.Text += (progress.BytesDownloaded);
                                                                                    break;
                                                                                }
                                                                            case DownloadStatus.Completed:
                                                                                {
                                                                                    Console.WriteLine("Download complete.");

                                                                                    logFile.WriteLine(fileName + " downloaded successfully\n");
                                                                                    break;
                                                                                }
                                                                            case DownloadStatus.Failed:
                                                                                {
                                                                                    oops = 1;
                                                                                    logFile.WriteLine(fileName + " could not be downloaded. Possible Google draw/form OR bad name.\n");
                                                                                    break;
                                                                                }
                                                                        }
                                                                    };
                                                                request.Download(stream);
                                                                if (oops == 1)
                                                                {
                                                                    txtLog.Text += (Environment.NewLine + fileName + " could not be downloaded. Possible Google draw/form OR bad name.\n" + Environment.NewLine);
                                                                    stream.Close();
                                                                    stream.Dispose();
                                                                }
                                                                else
                                                                {
                                                                    // Move file to the FS directory.
                                                                    stream.Close();
                                                                    stream.Dispose();
                                                                    while (foundmatch != folderfilelen)
                                                                    {
                                                                        foreach (string folders in foldervalues)
                                                                        {
                                                                            var split = folders.Split(',');
                                                                            string folderid = split[0];
                                                                            string foldername = split[1];
                                                                            if (folder == folderid)
                                                                            {
                                                                                txtLog.Text += Environment.NewLine + "Info: Moving file to correct directory";
                                                                                string filetomove = (savelocation + fileName + ext);
                                                                                string dest1 = (foldername + fileName + ext);
                                                                                var copyfrom = Path.Combine(savelocation, fileName + ext);
                                                                                File.Move(lblFile.Text,dest1);
                                                                                throw new Exception("File moved to: "+dest1);
                                                                            }
                                                                            else
                                                                            {
                                                                                foundmatch++;
                                                                            }
                                                                        }
                                                                    }
                                                                    txtLog.Text += (Environment.NewLine+"Download complete." + Environment.NewLine);
                                                                }
                                                            }
                                                        }
                                                    }
                                                    catch (Exception ex)
                                                    {

                                                        // Well, we found a file that isn't usable or convertable
                                                        // we typically see this with a google form or google draw file, too.
                                                        Console.Write("\nInfo: ---> " + ex.Message.ToString() + "\n");
                                                        txtLog.Text += (Environment.NewLine + "Info: " + ex.Message.ToString() + Environment.NewLine);
                                                    }
                                                }


                                            }
                                            Console.WriteLine("\n\n\tBackup completed for selected user!");
                                            lblFile.Text = "";
                                            txtLog.Text += ("Backup completed for current selected user!" + Environment.NewLine);
                                            proBar1.Value = 0;
                                            btnStart.Text = "&Start Backup";
                                            logFile.Close();
                                            logFile.Dispose();
                                        }
                                    }

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Info: " + ex.Message.ToString());
                                    txtLog.Text += (Environment.NewLine + "Info: " + ex.Message.ToString() + Environment.NewLine);
                                }
                            }

                            else
                            {
                                Console.WriteLine("No data found in " + users);
                                txtLog.Text += ("No data found in " + users);
                            }

                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Info: " + ex.Message.ToString());
                    txtLog.Text += (Environment.NewLine);
                    //txtLog.Text += (Environment.NewLine + "Error: " + ex.Message.ToString());
                }
            }
        }

        private void bgW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
            proBar1.Value = e.ProgressPercentage;
        }

        private void bgW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            proBar1.Value = 0;
            proBar1.Visible = false;
            //stripLabel.Text = "Backup finished!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtDomain.Enabled = true;
            txtDomain.Text = ConfigurationManager.AppSettings["defaultdomain"];
        }

        private void lnkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                txtFile.Enabled = true;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "User text file (*.txt)|*.txt";
                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtFile.Text = ofd.FileName;
                }
                else
                {
                    stripLabel.Text = "Browse Canceled!";
                }
            }
            catch (Exception ex)
            {
                stripLabel.Text = ex.Message.ToString();
            }
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            proBar1.Value = 0;
            proBar1.Visible = false;
            bgW.CancelAsync();
            bgLDAP.CancelAsync();

        }

        private void chkLDAP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLDAP.Checked == true)
            {
                btnStart.Text = "Get AD List";
                txtFile.ReadOnly = true;
                txtDomain.Text = ConfigurationManager.AppSettings["defaultdomain"];
            }
            else
            {
                btnStart.Text = "Start Backup";
                txtFile.ReadOnly = false;
                txtFile.Text = "";
                txtDomain.Text = "";
            }
        }

        private void bgLDAP_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            var appSettings = ConfigurationManager.AppSettings;
            string checkreplace = ConfigurationManager.AppSettings["checkreplace"];
            string defaultdomain = "";
            string replacedomain = "";
            txtFile.Text = @"ldapusers.txt";
            int usercounter = 0;
            if (checkreplace == "yes")
            {
                defaultdomain = ConfigurationManager.AppSettings["defaultdomain"];
                replacedomain = ConfigurationManager.AppSettings["replacedomain"];
            }
            txtLog.Text += "Discovering users... Please wait." + Environment.NewLine;

            string directorylisttxt = @"ldapusers.txt";
            if (File.Exists(directorylisttxt))
                File.Delete(directorylisttxt);

            StreamWriter userstxt = new StreamWriter(directorylisttxt);
            string domain = txtDomain.Text;
            using (var context = new PrincipalContext(ContextType.Domain, domain))
            {
                using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
                {
                    foreach (var result in searcher.FindAll())
                    {

                        if (bgLDAP.CancellationPending)
                        {
                            e.Cancel = true;
                            stripLabel.Text = "Operation was canceled!";
                            break;
                        }

                        usercounter++;
                        stripLabel.Text = (usercounter + " users found.");
                        System.DirectoryServices.DirectoryEntry de = result.GetUnderlyingObject() as System.DirectoryServices.DirectoryEntry;
                        string replace_email = (string)(de.Properties["userPrincipalName"].Value);
                        // Did the user have a valid entry?
                        if (replace_email != null)
                        {
                            if (checkreplace == "yes")
                            {
                                replace_email = replace_email.Replace(defaultdomain, replacedomain);
                                userstxt.WriteLine(replace_email);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid user information. Proceeding to next entry.");
                        }

                    }
                    userstxt.Dispose();
                }

            }
        }

        private void bgLDAP_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStart.Text = "Start Backup Now";
            txtLog.Text += (Environment.NewLine + "Please click \"Start Backup Now\"" + Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtLog.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }

    public class CreateService
    {

        static readonly string SERVICE_ACCOUNT_EMAIL = ConfigurationManager.AppSettings["serviceemail"];
        static readonly string SERVICE_ACCOUNT_PKCS12_FILE_PATH = ConfigurationManager.AppSettings["domainkey"];



        /// <summary>
        /// Build a Drive service object authorized with the service account
        /// that acts on behalf of the given user.
        /// </summary>
        /// @param userEmail The email of the user.
        /// <returns>Drive service object.</returns>
        public static DriveService BuildService(String userEmail)
        {

            X509Certificate2 certificate = new X509Certificate2(SERVICE_ACCOUNT_PKCS12_FILE_PATH,
                "notasecret", X509KeyStorageFlags.Exportable);
            ServiceAccountCredential credential = new ServiceAccountCredential(
                new ServiceAccountCredential.Initializer(SERVICE_ACCOUNT_EMAIL)
                {
                    Scopes = new[] { DriveService.Scope.Drive },
                    User = userEmail
                }.FromCertificate(certificate));

            // Create the service.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Drive API Service Account Sample",
            });

            return service;
        }
    }
}