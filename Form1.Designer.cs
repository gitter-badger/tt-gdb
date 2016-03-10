namespace TuckerTech_GABackup_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.proBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.bgW = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lnkFile = new System.Windows.Forms.LinkLabel();
            this.chkLDAP = new System.Windows.Forms.CheckBox();
            this.bgLDAP = new System.ComponentModel.BackgroundWorker();
            this.btnCopyLog = new System.Windows.Forms.Button();
            this.btnSkipFile = new System.Windows.Forms.Button();
            this.bgSkipFile = new System.ComponentModel.BackgroundWorker();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtCurrentUser = new System.Windows.Forms.TextBox();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProgresslbl = new System.Windows.Forms.Label();
            this.lblCurrentToken = new System.Windows.Forms.Label();
            this.txtCurrentToken = new System.Windows.Forms.TextBox();
            this.lblPrevToken = new System.Windows.Forms.Label();
            this.txtPrevToken = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.preferencesToolStripMenuItem.Text = "&Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(13, 151);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(497, 228);
            this.txtLog.TabIndex = 1;
            this.txtLog.WordWrap = false;
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabel,
            this.proBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(522, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripLabel
            // 
            this.stripLabel.Name = "stripLabel";
            this.stripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // proBar1
            // 
            this.proBar1.Name = "proBar1";
            this.proBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // txtFile
            // 
            this.txtFile.Enabled = false;
            this.txtFile.Location = new System.Drawing.Point(10, 35);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(147, 20);
            this.txtFile.TabIndex = 3;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(235, 135);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(48, 13);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "Progress";
            // 
            // txtDomain
            // 
            this.txtDomain.Enabled = false;
            this.txtDomain.Location = new System.Drawing.Point(163, 35);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(116, 20);
            this.txtDomain.TabIndex = 9;
            // 
            // bgW
            // 
            this.bgW.WorkerReportsProgress = true;
            this.bgW.WorkerSupportsCancellation = true;
            this.bgW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgW_DoWork);
            this.bgW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgW_ProgressChanged);
            this.bgW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgW_RunWorkerCompleted);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(178, 61);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "&Start Backup";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Clear Log";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lnkFile
            // 
            this.lnkFile.AutoSize = true;
            this.lnkFile.Location = new System.Drawing.Point(7, 8);
            this.lnkFile.Name = "lnkFile";
            this.lnkFile.Size = new System.Drawing.Size(23, 13);
            this.lnkFile.TabIndex = 15;
            this.lnkFile.TabStop = true;
            this.lnkFile.Text = "File";
            this.lnkFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFile_LinkClicked);
            // 
            // chkLDAP
            // 
            this.chkLDAP.AutoSize = true;
            this.chkLDAP.Location = new System.Drawing.Point(163, 8);
            this.chkLDAP.Name = "chkLDAP";
            this.chkLDAP.Size = new System.Drawing.Size(97, 17);
            this.chkLDAP.TabIndex = 16;
            this.chkLDAP.Text = "Collect AD Info";
            this.chkLDAP.UseVisualStyleBackColor = true;
            this.chkLDAP.CheckedChanged += new System.EventHandler(this.chkLDAP_CheckedChanged);
            // 
            // bgLDAP
            // 
            this.bgLDAP.WorkerReportsProgress = true;
            this.bgLDAP.WorkerSupportsCancellation = true;
            this.bgLDAP.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLDAP_DoWork);
            this.bgLDAP.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLDAP_RunWorkerCompleted);
            // 
            // btnCopyLog
            // 
            this.btnCopyLog.Location = new System.Drawing.Point(129, 385);
            this.btnCopyLog.Name = "btnCopyLog";
            this.btnCopyLog.Size = new System.Drawing.Size(101, 23);
            this.btnCopyLog.TabIndex = 17;
            this.btnCopyLog.Text = "C&opy Log";
            this.btnCopyLog.UseVisualStyleBackColor = true;
            this.btnCopyLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSkipFile
            // 
            this.btnSkipFile.Location = new System.Drawing.Point(236, 385);
            this.btnSkipFile.Name = "btnSkipFile";
            this.btnSkipFile.Size = new System.Drawing.Size(101, 23);
            this.btnSkipFile.TabIndex = 18;
            this.btnSkipFile.Text = "&Skip File";
            this.btnSkipFile.UseVisualStyleBackColor = true;
            this.btnSkipFile.Visible = false;
            this.btnSkipFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(12, 411);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(0, 13);
            this.lblFile.TabIndex = 19;
            // 
            // txtCurrentUser
            // 
            this.txtCurrentUser.Enabled = false;
            this.txtCurrentUser.Location = new System.Drawing.Point(3, 20);
            this.txtCurrentUser.Name = "txtCurrentUser";
            this.txtCurrentUser.ReadOnly = true;
            this.txtCurrentUser.Size = new System.Drawing.Size(171, 20);
            this.txtCurrentUser.TabIndex = 20;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(0, 4);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(64, 13);
            this.lblCurrentUser.TabIndex = 21;
            this.lblCurrentUser.Text = "Current user";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblProgresslbl);
            this.panel1.Controls.Add(this.lblCurrentToken);
            this.panel1.Controls.Add(this.txtCurrentToken);
            this.panel1.Controls.Add(this.lblPrevToken);
            this.panel1.Controls.Add(this.txtPrevToken);
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Controls.Add(this.txtCurrentUser);
            this.panel1.Location = new System.Drawing.Point(310, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 22;
            // 
            // lblProgresslbl
            // 
            this.lblProgresslbl.AutoSize = true;
            this.lblProgresslbl.Location = new System.Drawing.Point(3, 79);
            this.lblProgresslbl.Name = "lblProgresslbl";
            this.lblProgresslbl.Size = new System.Drawing.Size(0, 13);
            this.lblProgresslbl.TabIndex = 26;
            // 
            // lblCurrentToken
            // 
            this.lblCurrentToken.AutoSize = true;
            this.lblCurrentToken.Location = new System.Drawing.Point(89, 41);
            this.lblCurrentToken.Name = "lblCurrentToken";
            this.lblCurrentToken.Size = new System.Drawing.Size(75, 13);
            this.lblCurrentToken.TabIndex = 25;
            this.lblCurrentToken.Text = "Current Token";
            // 
            // txtCurrentToken
            // 
            this.txtCurrentToken.Enabled = false;
            this.txtCurrentToken.Location = new System.Drawing.Point(92, 56);
            this.txtCurrentToken.Name = "txtCurrentToken";
            this.txtCurrentToken.ReadOnly = true;
            this.txtCurrentToken.Size = new System.Drawing.Size(82, 20);
            this.txtCurrentToken.TabIndex = 24;
            // 
            // lblPrevToken
            // 
            this.lblPrevToken.AutoSize = true;
            this.lblPrevToken.Location = new System.Drawing.Point(0, 41);
            this.lblPrevToken.Name = "lblPrevToken";
            this.lblPrevToken.Size = new System.Drawing.Size(61, 13);
            this.lblPrevToken.TabIndex = 23;
            this.lblPrevToken.Text = "Last Token";
            // 
            // txtPrevToken
            // 
            this.txtPrevToken.Enabled = false;
            this.txtPrevToken.Location = new System.Drawing.Point(3, 56);
            this.txtPrevToken.Name = "txtPrevToken";
            this.txtPrevToken.ReadOnly = true;
            this.txtPrevToken.Size = new System.Drawing.Size(82, 20);
            this.txtPrevToken.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDomain);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.chkLDAP);
            this.panel2.Controls.Add(this.txtFile);
            this.panel2.Controls.Add(this.lnkFile);
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 100);
            this.panel2.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnSkipFile);
            this.Controls.Add(this.btnCopyLog);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TT: Google Drive Backup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.TextBox txtDomain;
        private System.ComponentModel.BackgroundWorker bgW;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStripStatusLabel stripLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel lnkFile;
        private System.Windows.Forms.CheckBox chkLDAP;
        private System.ComponentModel.BackgroundWorker bgLDAP;
        private System.Windows.Forms.ToolStripProgressBar proBar1;
        private System.Windows.Forms.Button btnCopyLog;
        private System.Windows.Forms.Button btnSkipFile;
        private System.ComponentModel.BackgroundWorker bgSkipFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtCurrentUser;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProgresslbl;
        private System.Windows.Forms.Label lblCurrentToken;
        private System.Windows.Forms.TextBox txtCurrentToken;
        private System.Windows.Forms.Label lblPrevToken;
        private System.Windows.Forms.TextBox txtPrevToken;
        private System.Windows.Forms.Panel panel2;
    }
}

