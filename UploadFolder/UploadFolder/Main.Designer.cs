using System.Collections.Generic;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DisplayGridButton = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.SelectedInfoLabel = new System.Windows.Forms.Label();
            this.DisplayCountButton = new System.Windows.Forms.Button();
            this.MonthsBox = new System.Windows.Forms.ComboBox();
            this.InformationBox = new System.Windows.Forms.ComboBox();
            this.MonthsLabel = new System.Windows.Forms.Label();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.folderUploadDataSet = new UploadFolder.FolderUploadDataSet();
            this.fileInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileInfoTableAdapter = new UploadFolder.FolderUploadDataSetTableAdapters.FileInfoTableAdapter();
            this.folderUploadDataSet1 = new UploadFolder.FolderUploadDataSet();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderUploadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderUploadDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1113, 649);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1105, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SlectFolder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1105, 623);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UploadFolder";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage3.Controls.Add(this.DisplayGridButton);
            this.tabPage3.Controls.Add(this.DataGridView);
            this.tabPage3.Controls.Add(this.SelectedInfoLabel);
            this.tabPage3.Controls.Add(this.DisplayCountButton);
            this.tabPage3.Controls.Add(this.MonthsBox);
            this.tabPage3.Controls.Add(this.InformationBox);
            this.tabPage3.Controls.Add(this.MonthsLabel);
            this.tabPage3.Controls.Add(this.InformationLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1105, 623);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Reports";
            // 
            // DisplayGridButton
            // 
            this.DisplayGridButton.Location = new System.Drawing.Point(470, 237);
            this.DisplayGridButton.Name = "DisplayGridButton";
            this.DisplayGridButton.Size = new System.Drawing.Size(97, 32);
            this.DisplayGridButton.TabIndex = 8;
            this.DisplayGridButton.UseVisualStyleBackColor = true;
            this.DisplayGridButton.Visible = false;
            this.DisplayGridButton.Click += new System.EventHandler(this.DisplayGrid_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(168, 285);
            this.DataGridView.Name = "DataGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.Size = new System.Drawing.Size(745, 245);
            this.DataGridView.TabIndex = 7;
            this.DataGridView.Visible = false;
            // 
            // SelectedInfoLabel
            // 
            this.SelectedInfoLabel.AutoSize = true;
            this.SelectedInfoLabel.Location = new System.Drawing.Point(390, 247);
            this.SelectedInfoLabel.Name = "SelectedInfoLabel";
            this.SelectedInfoLabel.Size = new System.Drawing.Size(67, 13);
            this.SelectedInfoLabel.TabIndex = 5;
            this.SelectedInfoLabel.Text = "SelectedInfo";
            this.SelectedInfoLabel.Visible = false;
            // 
            // DisplayCountButton
            // 
            this.DisplayCountButton.Location = new System.Drawing.Point(448, 185);
            this.DisplayCountButton.Name = "DisplayCountButton";
            this.DisplayCountButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayCountButton.TabIndex = 4;
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
            this.MonthsBox.Location = new System.Drawing.Point(529, 116);
            this.MonthsBox.Name = "MonthsBox";
            this.MonthsBox.Size = new System.Drawing.Size(121, 21);
            this.MonthsBox.TabIndex = 3;
            // 
            // InformationBox
            // 
            this.InformationBox.BackColor = System.Drawing.SystemColors.Info;
            this.InformationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InformationBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InformationBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.InformationBox.FormattingEnabled = true;
            this.InformationBox.Location = new System.Drawing.Point(529, 65);
            this.InformationBox.Name = "InformationBox";
            this.InformationBox.Size = new System.Drawing.Size(121, 21);
            this.InformationBox.TabIndex = 2;
            this.InformationBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MonthsLabel
            // 
            this.MonthsLabel.AutoSize = true;
            this.MonthsLabel.Location = new System.Drawing.Point(390, 124);
            this.MonthsLabel.Name = "MonthsLabel";
            this.MonthsLabel.Size = new System.Drawing.Size(27, 13);
            this.MonthsLabel.TabIndex = 1;
            this.MonthsLabel.Text = "Last";
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Location = new System.Drawing.Point(339, 73);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(98, 13);
            this.InformationLabel.TabIndex = 0;
            this.InformationLabel.Text = "Type of Information";
            // 
            // folderUploadDataSet
            // 
            this.folderUploadDataSet.DataSetName = "FolderUploadDataSet";
            this.folderUploadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fileInfoBindingSource
            // 
            this.fileInfoBindingSource.DataMember = "FileInfo";
            this.fileInfoBindingSource.DataSource = this.folderUploadDataSet;
            // 
            // fileInfoTableAdapter
            // 
            this.fileInfoTableAdapter.ClearBeforeFill = true;
            // 
            // folderUploadDataSet1
            // 
            this.folderUploadDataSet1.DataSetName = "FolderUploadDataSet";
            this.folderUploadDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 652);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderUploadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderUploadDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button DisplayCountButton;
        private System.Windows.Forms.ComboBox MonthsBox;
        private System.Windows.Forms.ComboBox InformationBox;
        private System.Windows.Forms.Label MonthsLabel;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Label SelectedInfoLabel;
        private FolderUploadDataSet folderUploadDataSet;
        private System.Windows.Forms.BindingSource fileInfoBindingSource;
        private FolderUploadDataSetTableAdapters.FileInfoTableAdapter fileInfoTableAdapter;
        private FolderUploadDataSet folderUploadDataSet1;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button DisplayGridButton;
        
    }

}

