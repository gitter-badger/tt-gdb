namespace TuckerTech_GABackup_GUI
{
    partial class Preferences
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Setup");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Included Files");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Preferences", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblReplaceDomain = new System.Windows.Forms.Label();
            this.lblDefaultDomain = new System.Windows.Forms.Label();
            this.lblSaveLoc = new System.Windows.Forms.Label();
            this.txtDomainKey = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.txtDefaultDomain = new System.Windows.Forms.TextBox();
            this.txtReplaceDomain = new System.Windows.Forms.TextBox();
            this.linkChange = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlSetup = new System.Windows.Forms.Panel();
            this.pnlPreferences = new System.Windows.Forms.Panel();
            this.lblPreferences = new System.Windows.Forms.Label();
            this.pnlIncluded = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlSetup.SuspendLayout();
            this.pnlPreferences.SuspendLayout();
            this.pnlIncluded.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(575, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripLabel
            // 
            this.stripLabel.Name = "stripLabel";
            this.stripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 31);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nodeBasicSetup";
            treeNode1.Text = "Setup";
            treeNode2.Name = "nodeIncFiles";
            treeNode2.Text = "Included Files";
            treeNode3.Name = "Preferences";
            treeNode3.Text = "Preferences";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(124, 235);
            this.treeView1.TabIndex = 17;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(42, 35);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(64, 13);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "Domain Key";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(42, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Service Email";
            // 
            // lblReplaceDomain
            // 
            this.lblReplaceDomain.AutoSize = true;
            this.lblReplaceDomain.Location = new System.Drawing.Point(42, 153);
            this.lblReplaceDomain.Name = "lblReplaceDomain";
            this.lblReplaceDomain.Size = new System.Drawing.Size(86, 13);
            this.lblReplaceDomain.TabIndex = 3;
            this.lblReplaceDomain.Text = "Replace Domain";
            // 
            // lblDefaultDomain
            // 
            this.lblDefaultDomain.AutoSize = true;
            this.lblDefaultDomain.Location = new System.Drawing.Point(42, 127);
            this.lblDefaultDomain.Name = "lblDefaultDomain";
            this.lblDefaultDomain.Size = new System.Drawing.Size(80, 13);
            this.lblDefaultDomain.TabIndex = 4;
            this.lblDefaultDomain.Text = "Default Domain";
            // 
            // lblSaveLoc
            // 
            this.lblSaveLoc.AutoSize = true;
            this.lblSaveLoc.Location = new System.Drawing.Point(42, 89);
            this.lblSaveLoc.Name = "lblSaveLoc";
            this.lblSaveLoc.Size = new System.Drawing.Size(47, 13);
            this.lblSaveLoc.TabIndex = 5;
            this.lblSaveLoc.Text = "Save to:";
            // 
            // txtDomainKey
            // 
            this.txtDomainKey.Location = new System.Drawing.Point(132, 32);
            this.txtDomainKey.Name = "txtDomainKey";
            this.txtDomainKey.Size = new System.Drawing.Size(161, 20);
            this.txtDomainKey.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(132, 56);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.Location = new System.Drawing.Point(132, 82);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.Size = new System.Drawing.Size(161, 20);
            this.txtSaveLocation.TabIndex = 9;
            // 
            // txtDefaultDomain
            // 
            this.txtDefaultDomain.Location = new System.Drawing.Point(132, 124);
            this.txtDefaultDomain.Name = "txtDefaultDomain";
            this.txtDefaultDomain.Size = new System.Drawing.Size(161, 20);
            this.txtDefaultDomain.TabIndex = 10;
            // 
            // txtReplaceDomain
            // 
            this.txtReplaceDomain.Location = new System.Drawing.Point(132, 150);
            this.txtReplaceDomain.Name = "txtReplaceDomain";
            this.txtReplaceDomain.Size = new System.Drawing.Size(161, 20);
            this.txtReplaceDomain.TabIndex = 11;
            // 
            // linkChange
            // 
            this.linkChange.AutoSize = true;
            this.linkChange.Location = new System.Drawing.Point(299, 35);
            this.linkChange.Name = "linkChange";
            this.linkChange.Size = new System.Drawing.Size(42, 13);
            this.linkChange.TabIndex = 12;
            this.linkChange.TabStop = true;
            this.linkChange.Text = "Browse";
            this.linkChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChange_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(132, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(218, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(299, 85);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Browse";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pnlSetup
            // 
            this.pnlSetup.Controls.Add(this.txtDomainKey);
            this.pnlSetup.Controls.Add(this.linkLabel1);
            this.pnlSetup.Controls.Add(this.lblKey);
            this.pnlSetup.Controls.Add(this.lblEmail);
            this.pnlSetup.Controls.Add(this.btnCancel);
            this.pnlSetup.Controls.Add(this.lblReplaceDomain);
            this.pnlSetup.Controls.Add(this.btnSave);
            this.pnlSetup.Controls.Add(this.lblDefaultDomain);
            this.pnlSetup.Controls.Add(this.linkChange);
            this.pnlSetup.Controls.Add(this.lblSaveLoc);
            this.pnlSetup.Controls.Add(this.txtReplaceDomain);
            this.pnlSetup.Controls.Add(this.txtEmail);
            this.pnlSetup.Controls.Add(this.txtDefaultDomain);
            this.pnlSetup.Controls.Add(this.txtSaveLocation);
            this.pnlSetup.Location = new System.Drawing.Point(142, 31);
            this.pnlSetup.Name = "pnlSetup";
            this.pnlSetup.Size = new System.Drawing.Size(423, 235);
            this.pnlSetup.TabIndex = 18;
            // 
            // pnlPreferences
            // 
            this.pnlPreferences.Controls.Add(this.lblPreferences);
            this.pnlPreferences.Location = new System.Drawing.Point(142, 31);
            this.pnlPreferences.Name = "pnlPreferences";
            this.pnlPreferences.Size = new System.Drawing.Size(423, 26);
            this.pnlPreferences.TabIndex = 17;
            // 
            // lblPreferences
            // 
            this.lblPreferences.AutoSize = true;
            this.lblPreferences.Location = new System.Drawing.Point(139, 7);
            this.lblPreferences.Name = "lblPreferences";
            this.lblPreferences.Size = new System.Drawing.Size(134, 13);
            this.lblPreferences.TabIndex = 2;
            this.lblPreferences.Text = "Select an option on the left";
            // 
            // pnlIncluded
            // 
            this.pnlIncluded.Controls.Add(this.button1);
            this.pnlIncluded.Controls.Add(this.checkedListBox1);
            this.pnlIncluded.Controls.Add(this.label1);
            this.pnlIncluded.Location = new System.Drawing.Point(139, 54);
            this.pnlIncluded.Name = "pnlIncluded";
            this.pnlIncluded.Size = new System.Drawing.Size(423, 235);
            this.pnlIncluded.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup the following files:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "DOC",
            "GIF",
            "JPG",
            "LOG",
            "PDF",
            "PNG",
            "PPT",
            "TXT",
            "XLS"});
            this.checkedListBox1.Location = new System.Drawing.Point(132, 43);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(161, 154);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 314);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlPreferences);
            this.Controls.Add(this.pnlSetup);
            this.Controls.Add(this.pnlIncluded);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlSetup.ResumeLayout(false);
            this.pnlSetup.PerformLayout();
            this.pnlPreferences.ResumeLayout(false);
            this.pnlPreferences.PerformLayout();
            this.pnlIncluded.ResumeLayout(false);
            this.pnlIncluded.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripLabel;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblReplaceDomain;
        private System.Windows.Forms.Label lblDefaultDomain;
        private System.Windows.Forms.Label lblSaveLoc;
        private System.Windows.Forms.TextBox txtDomainKey;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSaveLocation;
        private System.Windows.Forms.TextBox txtDefaultDomain;
        private System.Windows.Forms.TextBox txtReplaceDomain;
        private System.Windows.Forms.LinkLabel linkChange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel pnlSetup;
        private System.Windows.Forms.Panel pnlPreferences;
        private System.Windows.Forms.Label lblPreferences;
        private System.Windows.Forms.Panel pnlIncluded;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}