namespace CSVExportProject
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpDatabaseLogin = new System.Windows.Forms.GroupBox();
            this.ckbxSQL_DirectIP = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtInstance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpExtract = new System.Windows.Forms.GroupBox();
            this.dgvGridPreview = new System.Windows.Forms.DataGridView();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnExtract = new System.Windows.Forms.Button();
            this.txtCommandString = new System.Windows.Forms.TextBox();
            this.grpBoxExportType = new System.Windows.Forms.GroupBox();
            this.chkBoxPreview = new System.Windows.Forms.CheckBox();
            this.cmbQuoted = new System.Windows.Forms.ComboBox();
            this.cmbDelimiter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpDatabaseLogin.SuspendLayout();
            this.grpExtract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGridPreview)).BeginInit();
            this.grpBoxExportType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatabaseLogin
            // 
            this.grpDatabaseLogin.Controls.Add(this.ckbxSQL_DirectIP);
            this.grpDatabaseLogin.Controls.Add(this.txtPassword);
            this.grpDatabaseLogin.Controls.Add(this.txtLogin);
            this.grpDatabaseLogin.Controls.Add(this.txtDatabase);
            this.grpDatabaseLogin.Controls.Add(this.txtInstance);
            this.grpDatabaseLogin.Controls.Add(this.label5);
            this.grpDatabaseLogin.Controls.Add(this.btnConnect);
            this.grpDatabaseLogin.Controls.Add(this.label4);
            this.grpDatabaseLogin.Controls.Add(this.label3);
            this.grpDatabaseLogin.Controls.Add(this.label2);
            this.grpDatabaseLogin.Location = new System.Drawing.Point(12, 12);
            this.grpDatabaseLogin.Name = "grpDatabaseLogin";
            this.grpDatabaseLogin.Size = new System.Drawing.Size(379, 152);
            this.grpDatabaseLogin.TabIndex = 24;
            this.grpDatabaseLogin.TabStop = false;
            this.grpDatabaseLogin.Text = "SQL Login Information";
            // 
            // ckbxSQL_DirectIP
            // 
            this.ckbxSQL_DirectIP.AutoSize = true;
            this.ckbxSQL_DirectIP.Location = new System.Drawing.Point(61, 124);
            this.ckbxSQL_DirectIP.Name = "ckbxSQL_DirectIP";
            this.ckbxSQL_DirectIP.Size = new System.Drawing.Size(147, 19);
            this.ckbxSQL_DirectIP.TabIndex = 22;
            this.ckbxSQL_DirectIP.Text = "Use Direct IP/Address";
            this.ckbxSQL_DirectIP.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(61, 95);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(312, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(61, 69);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(312, 20);
            this.txtLogin.TabIndex = 6;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(61, 43);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(312, 20);
            this.txtDatabase.TabIndex = 5;
            // 
            // txtInstance
            // 
            this.txtInstance.Location = new System.Drawing.Point(61, 17);
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(312, 20);
            this.txtInstance.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(298, 120);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 21);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Instance";
            // 
            // grpExtract
            // 
            this.grpExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExtract.Controls.Add(this.dgvGridPreview);
            this.grpExtract.Controls.Add(this.txtFolder);
            this.grpExtract.Controls.Add(this.lblFolder);
            this.grpExtract.Controls.Add(this.btnExtract);
            this.grpExtract.Controls.Add(this.txtCommandString);
            this.grpExtract.Enabled = false;
            this.grpExtract.Location = new System.Drawing.Point(12, 170);
            this.grpExtract.Name = "grpExtract";
            this.grpExtract.Size = new System.Drawing.Size(776, 426);
            this.grpExtract.TabIndex = 25;
            this.grpExtract.TabStop = false;
            this.grpExtract.Text = "SQL to Extract";
            // 
            // dgvGridPreview
            // 
            this.dgvGridPreview.AllowUserToResizeRows = false;
            this.dgvGridPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGridPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGridPreview.Location = new System.Drawing.Point(13, 199);
            this.dgvGridPreview.MultiSelect = false;
            this.dgvGridPreview.Name = "dgvGridPreview";
            this.dgvGridPreview.RowHeadersWidth = 51;
            this.dgvGridPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGridPreview.Size = new System.Drawing.Size(757, 190);
            this.dgvGridPreview.TabIndex = 4;
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFolder.Location = new System.Drawing.Point(55, 396);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(634, 20);
            this.txtFolder.TabIndex = 3;
            this.txtFolder.Text = "C:\\TestDirectory\\Export Test\\sample_file.csv";
            // 
            // lblFolder
            // 
            this.lblFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(10, 400);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(45, 15);
            this.lblFolder.TabIndex = 2;
            this.lblFolder.Text = "Folder:";
            // 
            // btnExtract
            // 
            this.btnExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExtract.Location = new System.Drawing.Point(695, 395);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 1;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // txtCommandString
            // 
            this.txtCommandString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandString.Location = new System.Drawing.Point(10, 20);
            this.txtCommandString.Multiline = true;
            this.txtCommandString.Name = "txtCommandString";
            this.txtCommandString.Size = new System.Drawing.Size(760, 172);
            this.txtCommandString.TabIndex = 0;
            // 
            // grpBoxExportType
            // 
            this.grpBoxExportType.Controls.Add(this.chkBoxPreview);
            this.grpBoxExportType.Controls.Add(this.cmbQuoted);
            this.grpBoxExportType.Controls.Add(this.cmbDelimiter);
            this.grpBoxExportType.Controls.Add(this.label6);
            this.grpBoxExportType.Controls.Add(this.label7);
            this.grpBoxExportType.Enabled = false;
            this.grpBoxExportType.Location = new System.Drawing.Point(391, 12);
            this.grpBoxExportType.Name = "grpBoxExportType";
            this.grpBoxExportType.Size = new System.Drawing.Size(280, 152);
            this.grpBoxExportType.TabIndex = 26;
            this.grpBoxExportType.TabStop = false;
            this.grpBoxExportType.Text = "Export Type";
            // 
            // chkBoxPreview
            // 
            this.chkBoxPreview.AutoSize = true;
            this.chkBoxPreview.Location = new System.Drawing.Point(202, 71);
            this.chkBoxPreview.Name = "chkBoxPreview";
            this.chkBoxPreview.Size = new System.Drawing.Size(72, 19);
            this.chkBoxPreview.TabIndex = 8;
            this.chkBoxPreview.Text = "Preview";
            this.chkBoxPreview.UseVisualStyleBackColor = true;
            // 
            // cmbQuoted
            // 
            this.cmbQuoted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuoted.FormattingEnabled = true;
            this.cmbQuoted.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbQuoted.Location = new System.Drawing.Point(120, 43);
            this.cmbQuoted.Name = "cmbQuoted";
            this.cmbQuoted.Size = new System.Drawing.Size(146, 21);
            this.cmbQuoted.TabIndex = 7;
            // 
            // cmbDelimiter
            // 
            this.cmbDelimiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDelimiter.FormattingEnabled = true;
            this.cmbDelimiter.Items.AddRange(new object[] {
            "comma (,)",
            "pip (|)",
            "Fixed Width",
            "Embedded File"});
            this.cmbDelimiter.Location = new System.Drawing.Point(120, 17);
            this.cmbDelimiter.Name = "cmbDelimiter";
            this.cmbDelimiter.Size = new System.Drawing.Size(146, 21);
            this.cmbDelimiter.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quoted";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Delimted Character";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.grpBoxExportType);
            this.Controls.Add(this.grpExtract);
            this.Controls.Add(this.grpDatabaseLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "SQL extract to CSV";
            this.grpDatabaseLogin.ResumeLayout(false);
            this.grpDatabaseLogin.PerformLayout();
            this.grpExtract.ResumeLayout(false);
            this.grpExtract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGridPreview)).EndInit();
            this.grpBoxExportType.ResumeLayout(false);
            this.grpBoxExportType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatabaseLogin;
        private System.Windows.Forms.CheckBox ckbxSQL_DirectIP;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtInstance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpExtract;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.TextBox txtCommandString;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.GroupBox grpBoxExportType;
        private System.Windows.Forms.ComboBox cmbQuoted;
        private System.Windows.Forms.ComboBox cmbDelimiter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvGridPreview;
        private System.Windows.Forms.CheckBox chkBoxPreview;
    }
}

