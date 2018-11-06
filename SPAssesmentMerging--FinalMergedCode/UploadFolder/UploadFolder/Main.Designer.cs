namespace UploadFolder
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Errorlabel1 = new System.Windows.Forms.Label();
            this.Errorlabel2 = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.Button();
            this.SelectedFolderLabel = new System.Windows.Forms.Label();
            this.SelectFolderLabel = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SelectedFolders = new System.Windows.Forms.ListBox();
            this.Browse = new System.Windows.Forms.Button();
            this.SelectedPathFolder = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lberror = new System.Windows.Forms.Label();
            this.Tbusername = new System.Windows.Forms.TextBox();
            this.Lbsitedetails = new System.Windows.Forms.Label();
            this.Btnconnect = new System.Windows.Forms.Button();
            this.Lbsiteurl = new System.Windows.Forms.Label();
            this.Tbpassword = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Tbsiteurl = new System.Windows.Forms.TextBox();
            this.Lbpassword = new System.Windows.Forms.Label();
            this.Lbdocumentlibrary = new System.Windows.Forms.Label();
            this.Lbfoldername = new System.Windows.Forms.Label();
            this.CbDocumentlibrary = new System.Windows.Forms.ComboBox();
            this.CBfoldername = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UnsupportedButton = new System.Windows.Forms.Button();
            this.UnsupportedFiles = new System.Windows.Forms.Label();
            this.FileTypeComboBox = new System.Windows.Forms.ComboBox();
            this.FileTypeLabel = new System.Windows.Forms.Label();
            this.SelectedInfoButton = new System.Windows.Forms.Button();
            this.SelectedInfoLabel = new System.Windows.Forms.Label();
            this.DisplayCountButton = new System.Windows.Forms.Button();
            this.MonthsBox = new System.Windows.Forms.ComboBox();
            this.InformationBox = new System.Windows.Forms.ComboBox();
            this.MonthsLabel = new System.Windows.Forms.Label();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FileTypeButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(25, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Errorlabel1);
            this.tabPage1.Controls.Add(this.Errorlabel2);
            this.tabPage1.Controls.Add(this.Run);
            this.tabPage1.Controls.Add(this.SelectedFolderLabel);
            this.tabPage1.Controls.Add(this.SelectFolderLabel);
            this.tabPage1.Controls.Add(this.Remove);
            this.tabPage1.Controls.Add(this.Add);
            this.tabPage1.Controls.Add(this.SelectedFolders);
            this.tabPage1.Controls.Add(this.Browse);
            this.tabPage1.Controls.Add(this.SelectedPathFolder);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SlectFolder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Errorlabel1
            // 
            this.Errorlabel1.AutoSize = true;
            this.Errorlabel1.Location = new System.Drawing.Point(323, 106);
            this.Errorlabel1.Name = "Errorlabel1";
            this.Errorlabel1.Size = new System.Drawing.Size(0, 13);
            this.Errorlabel1.TabIndex = 41;
            // 
            // Errorlabel2
            // 
            this.Errorlabel2.AutoSize = true;
            this.Errorlabel2.Location = new System.Drawing.Point(510, 202);
            this.Errorlabel2.Name = "Errorlabel2";
            this.Errorlabel2.Size = new System.Drawing.Size(0, 13);
            this.Errorlabel2.TabIndex = 40;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(390, 322);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 39;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // SelectedFolderLabel
            // 
            this.SelectedFolderLabel.AutoSize = true;
            this.SelectedFolderLabel.Location = new System.Drawing.Point(102, 159);
            this.SelectedFolderLabel.Name = "SelectedFolderLabel";
            this.SelectedFolderLabel.Size = new System.Drawing.Size(78, 13);
            this.SelectedFolderLabel.TabIndex = 38;
            this.SelectedFolderLabel.Text = "Selected folder";
            // 
            // SelectFolderLabel
            // 
            this.SelectFolderLabel.AutoSize = true;
            this.SelectFolderLabel.Location = new System.Drawing.Point(102, 65);
            this.SelectFolderLabel.Name = "SelectFolderLabel";
            this.SelectFolderLabel.Size = new System.Drawing.Size(69, 13);
            this.SelectFolderLabel.TabIndex = 37;
            this.SelectFolderLabel.Text = "Select Folder";
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(585, 159);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 36;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(585, 64);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 35;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // SelectedFolders
            // 
            this.SelectedFolders.FormattingEnabled = true;
            this.SelectedFolders.Location = new System.Drawing.Point(212, 159);
            this.SelectedFolders.Name = "SelectedFolders";
            this.SelectedFolders.Size = new System.Drawing.Size(253, 134);
            this.SelectedFolders.TabIndex = 34;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(460, 65);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 33;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // SelectedPathFolder
            // 
            this.SelectedPathFolder.Location = new System.Drawing.Point(212, 67);
            this.SelectedPathFolder.Name = "SelectedPathFolder";
            this.SelectedPathFolder.Size = new System.Drawing.Size(253, 20);
            this.SelectedPathFolder.TabIndex = 32;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.IndianRed;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.BtnUpload);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.Lbdocumentlibrary);
            this.tabPage2.Controls.Add(this.Lbfoldername);
            this.tabPage2.Controls.Add(this.CbDocumentlibrary);
            this.tabPage2.Controls.Add(this.CBfoldername);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UploadFolder";
            // 
            // BtnUpload
            // 
            this.BtnUpload.Location = new System.Drawing.Point(326, 372);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(79, 26);
            this.BtnUpload.TabIndex = 6;
            this.BtnUpload.Text = "Upload";
            this.BtnUpload.UseVisualStyleBackColor = true;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.Lberror);
            this.groupBox1.Controls.Add(this.Tbusername);
            this.groupBox1.Controls.Add(this.Lbsitedetails);
            this.groupBox1.Controls.Add(this.Btnconnect);
            this.groupBox1.Controls.Add(this.Lbsiteurl);
            this.groupBox1.Controls.Add(this.Tbpassword);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Controls.Add(this.Tbsiteurl);
            this.groupBox1.Controls.Add(this.Lbpassword);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(97, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 222);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Lberror
            // 
            this.Lberror.AutoSize = true;
            this.Lberror.BackColor = System.Drawing.Color.Gray;
            this.Lberror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lberror.ForeColor = System.Drawing.Color.Transparent;
            this.Lberror.Location = new System.Drawing.Point(268, 181);
            this.Lberror.Name = "Lberror";
            this.Lberror.Size = new System.Drawing.Size(0, 16);
            this.Lberror.TabIndex = 4;
            // 
            // Tbusername
            // 
            this.Tbusername.Location = new System.Drawing.Point(159, 105);
            this.Tbusername.Name = "Tbusername";
            this.Tbusername.Size = new System.Drawing.Size(154, 20);
            this.Tbusername.TabIndex = 2;
            // 
            // Lbsitedetails
            // 
            this.Lbsitedetails.AutoSize = true;
            this.Lbsitedetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbsitedetails.Location = new System.Drawing.Point(18, 26);
            this.Lbsitedetails.Name = "Lbsitedetails";
            this.Lbsitedetails.Size = new System.Drawing.Size(121, 25);
            this.Lbsitedetails.TabIndex = 1;
            this.Lbsitedetails.Text = "Site Details";
            // 
            // Btnconnect
            // 
            this.Btnconnect.Location = new System.Drawing.Point(228, 179);
            this.Btnconnect.Name = "Btnconnect";
            this.Btnconnect.Size = new System.Drawing.Size(79, 26);
            this.Btnconnect.TabIndex = 3;
            this.Btnconnect.Text = "Connect";
            this.Btnconnect.UseVisualStyleBackColor = true;
            this.Btnconnect.Click += new System.EventHandler(this.Btnconnect_Click);
            // 
            // Lbsiteurl
            // 
            this.Lbsiteurl.AutoSize = true;
            this.Lbsiteurl.Location = new System.Drawing.Point(89, 77);
            this.Lbsiteurl.Name = "Lbsiteurl";
            this.Lbsiteurl.Size = new System.Drawing.Size(41, 13);
            this.Lbsiteurl.TabIndex = 1;
            this.Lbsiteurl.Text = "Site Url";
            // 
            // Tbpassword
            // 
            this.Tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbpassword.Location = new System.Drawing.Point(159, 132);
            this.Tbpassword.Name = "Tbpassword";
            this.Tbpassword.PasswordChar = '*';
            this.Tbpassword.Size = new System.Drawing.Size(154, 26);
            this.Tbpassword.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(78, 108);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(60, 13);
            this.Username.TabIndex = 1;
            this.Username.Text = "User Name";
            // 
            // Tbsiteurl
            // 
            this.Tbsiteurl.Location = new System.Drawing.Point(159, 75);
            this.Tbsiteurl.Name = "Tbsiteurl";
            this.Tbsiteurl.Size = new System.Drawing.Size(274, 20);
            this.Tbsiteurl.TabIndex = 2;
            // 
            // Lbpassword
            // 
            this.Lbpassword.AutoSize = true;
            this.Lbpassword.Location = new System.Drawing.Point(80, 144);
            this.Lbpassword.Name = "Lbpassword";
            this.Lbpassword.Size = new System.Drawing.Size(53, 13);
            this.Lbpassword.TabIndex = 1;
            this.Lbpassword.Text = "Password";
            // 
            // Lbdocumentlibrary
            // 
            this.Lbdocumentlibrary.AutoSize = true;
            this.Lbdocumentlibrary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbdocumentlibrary.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbdocumentlibrary.Location = new System.Drawing.Point(220, 333);
            this.Lbdocumentlibrary.Name = "Lbdocumentlibrary";
            this.Lbdocumentlibrary.Size = new System.Drawing.Size(146, 17);
            this.Lbdocumentlibrary.TabIndex = 1;
            this.Lbdocumentlibrary.Text = "Document Library";
            // 
            // Lbfoldername
            // 
            this.Lbfoldername.AutoSize = true;
            this.Lbfoldername.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbfoldername.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbfoldername.Location = new System.Drawing.Point(242, 53);
            this.Lbfoldername.Name = "Lbfoldername";
            this.Lbfoldername.Size = new System.Drawing.Size(102, 17);
            this.Lbfoldername.TabIndex = 1;
            this.Lbfoldername.Text = "Folder Name";
            // 
            // CbDocumentlibrary
            // 
            this.CbDocumentlibrary.BackColor = System.Drawing.Color.AliceBlue;
            this.CbDocumentlibrary.FormattingEnabled = true;
            this.CbDocumentlibrary.Location = new System.Drawing.Point(378, 332);
            this.CbDocumentlibrary.Name = "CbDocumentlibrary";
            this.CbDocumentlibrary.Size = new System.Drawing.Size(121, 21);
            this.CbDocumentlibrary.TabIndex = 0;
            // 
            // CBfoldername
            // 
            this.CBfoldername.BackColor = System.Drawing.Color.Linen;
            this.CBfoldername.FormattingEnabled = true;
            this.CBfoldername.Location = new System.Drawing.Point(384, 51);
            this.CBfoldername.Name = "CBfoldername";
            this.CBfoldername.Size = new System.Drawing.Size(121, 21);
            this.CBfoldername.TabIndex = 0;
            this.CBfoldername.SelectedIndexChanged += new System.EventHandler(this.CBfoldername_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.FileTypeButton);
            this.tabPage3.Controls.Add(this.reportViewer1);
            this.tabPage3.Controls.Add(this.UnsupportedButton);
            this.tabPage3.Controls.Add(this.UnsupportedFiles);
            this.tabPage3.Controls.Add(this.FileTypeComboBox);
            this.tabPage3.Controls.Add(this.FileTypeLabel);
            this.tabPage3.Controls.Add(this.SelectedInfoButton);
            this.tabPage3.Controls.Add(this.SelectedInfoLabel);
            this.tabPage3.Controls.Add(this.DisplayCountButton);
            this.tabPage3.Controls.Add(this.MonthsBox);
            this.tabPage3.Controls.Add(this.InformationBox);
            this.tabPage3.Controls.Add(this.MonthsLabel);
            this.tabPage3.Controls.Add(this.InformationLabel);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(763, 409);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Reports";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(339, 70);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(401, 297);
            this.reportViewer1.TabIndex = 34;
            // 
            // UnsupportedButton
            // 
            this.UnsupportedButton.Location = new System.Drawing.Point(155, 367);
            this.UnsupportedButton.Name = "UnsupportedButton";
            this.UnsupportedButton.Size = new System.Drawing.Size(121, 23);
            this.UnsupportedButton.TabIndex = 33;
            this.UnsupportedButton.UseVisualStyleBackColor = true;
            this.UnsupportedButton.Click += new System.EventHandler(this.UnsupportedButton_Click);
            // 
            // UnsupportedFiles
            // 
            this.UnsupportedFiles.AutoSize = true;
            this.UnsupportedFiles.Location = new System.Drawing.Point(19, 372);
            this.UnsupportedFiles.Name = "UnsupportedFiles";
            this.UnsupportedFiles.Size = new System.Drawing.Size(92, 13);
            this.UnsupportedFiles.TabIndex = 32;
            this.UnsupportedFiles.Text = "Unsupported Files";
            // 
            // FileTypeComboBox
            // 
            this.FileTypeComboBox.FormattingEnabled = true;
            this.FileTypeComboBox.Location = new System.Drawing.Point(87, 300);
            this.FileTypeComboBox.Name = "FileTypeComboBox";
            this.FileTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.FileTypeComboBox.TabIndex = 31;
            this.FileTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FileTypeComboBox_SelectedIndexChanged);
            // 
            // FileTypeLabel
            // 
            this.FileTypeLabel.AutoSize = true;
            this.FileTypeLabel.Location = new System.Drawing.Point(19, 308);
            this.FileTypeLabel.Name = "FileTypeLabel";
            this.FileTypeLabel.Size = new System.Drawing.Size(47, 13);
            this.FileTypeLabel.TabIndex = 30;
            this.FileTypeLabel.Text = "FileType";
            // 
            // SelectedInfoButton
            // 
            this.SelectedInfoButton.Location = new System.Drawing.Point(102, 219);
            this.SelectedInfoButton.Name = "SelectedInfoButton";
            this.SelectedInfoButton.Size = new System.Drawing.Size(129, 32);
            this.SelectedInfoButton.TabIndex = 29;
            this.SelectedInfoButton.UseVisualStyleBackColor = true;
            this.SelectedInfoButton.Visible = false;
            this.SelectedInfoButton.Click += new System.EventHandler(this.SelectedInfoButton_Click);
            // 
            // SelectedInfoLabel
            // 
            this.SelectedInfoLabel.AutoSize = true;
            this.SelectedInfoLabel.Location = new System.Drawing.Point(19, 229);
            this.SelectedInfoLabel.Name = "SelectedInfoLabel";
            this.SelectedInfoLabel.Size = new System.Drawing.Size(67, 13);
            this.SelectedInfoLabel.TabIndex = 28;
            this.SelectedInfoLabel.Text = "SelectedInfo";
            this.SelectedInfoLabel.Visible = false;
            // 
            // DisplayCountButton
            // 
            this.DisplayCountButton.Location = new System.Drawing.Point(102, 166);
            this.DisplayCountButton.Name = "DisplayCountButton";
            this.DisplayCountButton.Size = new System.Drawing.Size(89, 26);
            this.DisplayCountButton.TabIndex = 27;
            this.DisplayCountButton.Text = "Display ";
            this.DisplayCountButton.UseVisualStyleBackColor = true;
            this.DisplayCountButton.Click += new System.EventHandler(this.DisplayCountButton_Click);
            // 
            // MonthsBox
            // 
            this.MonthsBox.FormattingEnabled = true;
            this.MonthsBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "6",
            "12"});
            this.MonthsBox.Location = new System.Drawing.Point(155, 108);
            this.MonthsBox.Name = "MonthsBox";
            this.MonthsBox.Size = new System.Drawing.Size(116, 21);
            this.MonthsBox.TabIndex = 26;
            // 
            // InformationBox
            // 
            this.InformationBox.BackColor = System.Drawing.SystemColors.Info;
            this.InformationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InformationBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InformationBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InformationBox.FormattingEnabled = true;
            this.InformationBox.Location = new System.Drawing.Point(155, 44);
            this.InformationBox.Name = "InformationBox";
            this.InformationBox.Size = new System.Drawing.Size(116, 21);
            this.InformationBox.TabIndex = 25;
            // 
            // MonthsLabel
            // 
            this.MonthsLabel.AutoSize = true;
            this.MonthsLabel.Location = new System.Drawing.Point(19, 108);
            this.MonthsLabel.Name = "MonthsLabel";
            this.MonthsLabel.Size = new System.Drawing.Size(67, 13);
            this.MonthsLabel.TabIndex = 24;
            this.MonthsLabel.Text = "SelectMonth";
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Location = new System.Drawing.Point(19, 42);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(98, 13);
            this.InformationLabel.TabIndex = 23;
            this.InformationLabel.Text = "Type of Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 22;
            // 
            // FileTypeButton
            // 
            this.FileTypeButton.Location = new System.Drawing.Point(232, 298);
            this.FileTypeButton.Name = "FileTypeButton";
            this.FileTypeButton.Size = new System.Drawing.Size(75, 23);
            this.FileTypeButton.TabIndex = 35;
            this.FileTypeButton.UseVisualStyleBackColor = true;
            this.FileTypeButton.Click += new System.EventHandler(this.FileTypeButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 503);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label Lbfoldername;
        private System.Windows.Forms.ComboBox CBfoldername;
        private System.Windows.Forms.Label Lbsitedetails;
        private System.Windows.Forms.Button Btnconnect;
        private System.Windows.Forms.TextBox Tbpassword;
        private System.Windows.Forms.TextBox Tbusername;
        private System.Windows.Forms.Label Lbpassword;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Lbsiteurl;
        private System.Windows.Forms.Label Lbdocumentlibrary;
        private System.Windows.Forms.ComboBox CbDocumentlibrary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Tbsiteurl;
        private System.Windows.Forms.Label Lberror;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.Label Errorlabel1;
        private System.Windows.Forms.Label Errorlabel2;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label SelectedFolderLabel;
        private System.Windows.Forms.Label SelectFolderLabel;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox SelectedFolders;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox SelectedPathFolder;
        private System.Windows.Forms.Button UnsupportedButton;
        private System.Windows.Forms.Label UnsupportedFiles;
        private System.Windows.Forms.ComboBox FileTypeComboBox;
        private System.Windows.Forms.Label FileTypeLabel;
        private System.Windows.Forms.Button SelectedInfoButton;
        private System.Windows.Forms.Label SelectedInfoLabel;
        private System.Windows.Forms.Button DisplayCountButton;
        private System.Windows.Forms.ComboBox MonthsBox;
        private System.Windows.Forms.ComboBox InformationBox;
        private System.Windows.Forms.Label MonthsLabel;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button FileTypeButton;
    }
}

