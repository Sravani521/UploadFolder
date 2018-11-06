using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.Security.Principal;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;
using Microsoft.SharePoint.Client;
using System.IO;
using DAL.Repository;
using DAL;
using DAL.Model;
using Microsoft.Reporting.WinForms;
using Microsoft.Office.Server;
//using Microsoft.Reporting.WinForms;
using System.Diagnostics;

namespace UploadFolder
{
    public partial class Main : System.Windows.Forms.Form
    {
        public static string UserName;
        public static SecureString Password;
        public static string Url;
        public static ClientContext Clientcontext;
        IList<string> RootFoldersPath = new List<string>();  // list for RootFoldersPath
        IList<string> SubFoldersPath = new List<string>();   // list for SubFoldersPath
        GetReportsRepository RepObj = new GetReportsRepository();
        DataTable FileInfoTable;

        public Main()
        {
         
            InitializeComponent();
            DataTable data = RepObj.GetFileType();

            foreach (DataRow Dr in data.Rows)
            {
                foreach (var item in Dr.ItemArray)
                {
                    FileTypeComboBox.Items.Add(item);
                }
            }

            UnsupportedButton.Text=RepObj.GetUnsupportedFiles();

            /*----------------- Assigning the Data to FolderComboBox-------------------------*/

            GetRootFolderRepository getRootFolder = new GetRootFolderRepository();
            CBfoldername.DataSource = getRootFolder.BindingFolders();
            CBfoldername.DisplayMember = "Name";
            CBfoldername.ValueMember = "Path";

            FileInfoTable = RepObj.GetFileInfoTable();

            /*----------------- Assigning the Data to TypeOfInformation ComboBox-------------------------*/

            Dictionary<string, string> ComboBoxItems = new Dictionary<string, string>();
            ComboBoxItems.Add("CreatedOn", "Created");
            ComboBoxItems.Add("ModifiedOn", "Modified");
            ComboBoxItems.Add("FileAccessed", "Accesed");           
            InformationBox.DataSource = new BindingSource(ComboBoxItems, null);
            InformationBox.DisplayMember = "Value";
            InformationBox.ValueMember = "Key";
            MonthsBox.SelectedItem = "1";
            



        }

        /*----------------- For Connectng To Sharepoint After Given Credentials-------------------------*/

        private void Btnconnect_Click(object sender, EventArgs e)
        {
            UserName = Tbusername.Text;
            Password = new SecureString();
            foreach (char c in Tbpassword.Text)
            {
                Password.AppendChar(c);
            }

            Url = Tbsiteurl.Text;
            Lberror.Text = "Please wait connecting to sharepoint";

            try
            {
                Clientcontext = new ClientContext(Url);
                Clientcontext.Credentials = new SharePointOnlineCredentials(UserName, Password);
            }
            catch (Microsoft.SharePoint.Client.IdcrlException ex)
            {
                ErrrorLog.ErrorlogWrite(ex);
                Lberror.Text = "The sign-in name or password does not match one in the Microsoft account system";
            }
            catch (Microsoft.SharePoint.Client.ClientRequestException ex)
            {
                ErrrorLog.ErrorlogWrite(ex);
                Lberror.Text = "Cannot contact site ysou are specified";
            }
            catch (Exception ex)
            {
                ErrrorLog.ErrorlogWrite(ex);
                Lberror.Text = "Please check the data what you provided";
            }
            try
            {
                /*----------------- Retriving All Document Library's from Sharepoint Assigning To Combobox-------------------------*/

                Web Webobject = Clientcontext.Web;
                var DocumentLibrary = Clientcontext.LoadQuery(Webobject.Lists.Where(l => l.BaseTemplate == 101));
                Clientcontext.ExecuteQuery();
                IList<string> DocLibraryList = new List<string>();

                foreach (var List in DocumentLibrary)
                {
                    DocLibraryList.Add(List.Title);
                }

                Lberror.Text = "";
                CbDocumentlibrary.DataSource = DocLibraryList;
                CbDocumentlibrary.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                ErrrorLog.ErrorlogWrite(ex);
                Lberror.Text = "Please check the data what you provided";
            }

        }

        /*----------------- For Uploading Selected Folder into Sharepoint-------------------------*/

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            SPUploadFolder SPUpload = new SPUploadFolder();
            string Path = CBfoldername.SelectedValue.ToString();

            string[] Splitpath = Path.Split(Convert.ToChar(92));
            if (Splitpath.Length > 2)
            {
                //Create Folders in document library if rootfolder path have more then 1 folders
                SPUpload.CreateFolder(Clientcontext, Path, CbDocumentlibrary.SelectedItem.ToString());
            }
            else
            {
                //Create Folders in document library if rootfolder path have only 1 Folder
                SPUpload.UploadFoldersRecursively(Clientcontext, Path, CbDocumentlibrary.SelectedItem.ToString());
            }
        }

        /*----------------- getting the text from (InformationBox)Combobox to the SelectedInfoLabel-------------------------*/

        private void DisplayCountButton_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedInfoLabel.Text = InformationBox.SelectedItem.ToString();
                SelectedInfoLabel.Text = InformationBox.SelectedValue.ToString();
                SelectedInfoLabel.Visible = true;
                SelectedInfoButton.Visible = true;


                //this line of code loads the InformationBox data and MonthsBox data and displays it in the DisplayGridButton

                SelectedInfoButton.Text = RepObj.Getdata(InformationBox.SelectedValue.ToString(), MonthsBox.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                ErrrorLog.ErrorlogWrite(ex);
            }
        }

        /*-----------------retreiving the data from the database and Fill the data to ReportViewer-------------------------*/

        private void SelectedInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                ////this.DataGridView.Visible = true;
               // DataTable DatatableObj = RepObj.GetInformation(InformationBox.SelectedValue.ToString(), MonthsBox.SelectedItem.ToString());

                //reportViewer1.Visible = true;
                ////reportViewer1.LocalReport.DataSources.Clear();
                ////ReportDataSource rptData = new ReportDataSource("dsSource", DatatableObj);

                //reportViewer1.ProcessingMode = ProcessingMode.Local;
                ////reportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report.rdlc");
                //DataTable dsCustomers = DatatableObj;

                //ReportDataSource datasource = new ReportDataSource("Customers", dsCustomers);
                //reportViewer1.LocalReport.DataSources.Clear();
                //reportViewer1.LocalReport.DataSources.Add(datasource);


             
                //ReportDataSource datasource = new ReportDataSource("FileInfo", DatatableObj.Rows);
                this.reportViewer1.LocalReport.DataSources.Clear();
                //this.reportViewer1.LocalReport.DataSources.Add(datasource);
                this.reportViewer1.RefreshReport();




                //LocalReport r = new LocalReport();          
                //r.DataSources.Add(rptData);

                //reportViewer1.LocalReport.DataSources.Add(rptData);
                //reportViewer1.LocalReport.Refresh();
            }
            catch (Exception ex)
            {
                ErrrorLog.ErrorlogWrite(ex);
            }
        }

        // ---------------------------------------Browsing the Folders--------------------------------------//
        private void Browse_Click(object sender, EventArgs e)
        {
            Errorlabel1.Text = "";
            Errorlabel2.Text = "";
            using (FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog())
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    SelectedPathFolder.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }

        // ------------------------------Adding the browsed Folders to the list and listbox -------------------------//

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                Errorlabel2.Text = "";
                Errorlabel1.Text = "";
                string folderpath;
                if (SelectedPathFolder.Text == "" || SelectedPathFolder.Text == null)  //throwing error when listbox is empty
                {
                    throw new Exception("Please Browse the folder");
                }
                else
                {
                    Errorlabel1.Text = "";
                    folderpath = SelectedPathFolder.Text;  //assigning browsed folderpath to variable 
                    RootFoldersPath.Add(folderpath);      // adding the selected folderpath to list
                    Boolean IfItemIsExists = false;
                    foreach (string PresentFilePath in RootFoldersPath)  // getting each folderpath in list
                    {
                        if (folderpath.Equals(PresentFilePath))   // comparing with folderpath in list with present folderpath
                        {
                            IfItemIsExists = true;
                        }
                    }
                    if (IfItemIsExists)  // if exists removing the folderpath in list
                    {
                        RootFoldersPath.Remove(folderpath);
                        int ExistedFilePlace = folderpath.LastIndexOf("\\");
                        String ExistedfileName = folderpath.Substring(ExistedFilePlace + 1);
                        SelectedFolders.Items.Remove(ExistedfileName);
                    }
                    RootFoldersPath.Add(folderpath);  // adding folderpath to list
                    int LastIndexOf = folderpath.LastIndexOf("\\");   // getting foldername instead of taking the folderpath
                    String fileName = folderpath.Substring(LastIndexOf + 1);
                    SelectedFolders.Items.Add(fileName);  // adding foldername to listbox
                    SelectedPathFolder.Text = "";   // empty the browsing textbox
                }
            }
            catch (Exception Ex)
            {
                Errorlabel1.Text = Ex.Message;   // error message if not browsed 
                ErrrorLog.ErrorlogWrite(Ex);     // error message to log file
            }

        }

        // ------------------------------Removing the selected Folders from the list and listbox -------------------------//
        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                string Folderpath = "";
                foreach (string path in RootFoldersPath)  // getting each folderpath in list
                {
                    Folderpath = path;
                }
                if ((Folderpath == "" || Folderpath == null) && (SelectedFolders.Text == "" || SelectedFolders.Text == null))  // if browsing textbox is empty
                {
                    throw new Exception("Please Browse the folder");
                }
                else if (SelectedFolders.Text == "" || SelectedFolders.Text == null || SelectedFolders.SelectedItem.ToString() == null) // if not selected the foldername to remove
                {
                    throw new Exception("Please Select Folder");
                }

                else
                {
                    Errorlabel2.Text = "";
                    Errorlabel1.Text = "";

                    string foldername = SelectedFolders.SelectedItem.ToString(); // selecting the foldername to remove

                    SelectedFolders.Items.Remove(foldername);   // removing the selected folders in listbox
                    String RemovingItem = "";

                    foreach (String path in RootFoldersPath)   // getting each folderpath in list
                    {
                        int LastIndexOf = path.LastIndexOf("\\");
                        String folderName = path.Substring(LastIndexOf + 1); // getting foldername in list
                        if (folderName.Equals(foldername))  // if selected foldername equals to list foldername
                        {
                            RemovingItem = path;
                        }
                    }
                    RootFoldersPath.Remove(RemovingItem);   // removing the selected path from list
                }
            }
            catch (Exception Ex)
            {
                Errorlabel1.Text = Ex.Message;   // exception message 
                ErrrorLog.ErrorlogWrite(Ex);
            }
        }

        // ------------------------------Sending the data to database-------------------------//
        private void Run_Click(object sender, EventArgs e)
        {
            SelectFolder selectFolder = new SelectFolder();
            try
            {
                string folderpath = "";
                foreach (string path in RootFoldersPath)  // getting each folderpath in list
                {
                    folderpath = path;
                }
                if (folderpath == "" || folderpath == null)   // if folderpath is empty
                {
                    throw new Exception("Please Browse the folder");  //throw exception
                }
                else
                {
                    Errorlabel2.Text = "";
                    Errorlabel1.Text = "";
                    string[] subfolders = Directory.GetDirectories(folderpath, "*", SearchOption.AllDirectories); // getting all subfolders into variable
                    string[] files = Directory.GetFiles(folderpath, "*", SearchOption.AllDirectories);   // getting all files into variable
                    foreach (String Rootfolder in RootFoldersPath) //Getting each rootfolder from list
                    {
                        try
                        {
                            DAL.Repository.FileInformation dbcall = new DAL.Repository.FileInformation();
                            RootFolder RootFolderDetails = selectFolder.GetRootFolderdetails(Rootfolder); //Getting rootfolder details
                            int ID = dbcall.UploadRootFolder(RootFolderDetails);//Upload into the database and method is return the inserted id. ID is usefully for files
                            selectFolder.GetSubDirectories(Rootfolder, ID); //Getting all sub folders and files
                        }
                        catch (Exception Ex)
                        {

                            ErrrorLog.ErrorlogWrite(Ex);
                        }
                    }
                    
                }

                /*----------------- Assigning the Data to FolderComboBox Again-------------------------*/

                GetRootFolderRepository getRootFolder = new GetRootFolderRepository();
                CBfoldername.DataSource = getRootFolder.BindingFolders();
                CBfoldername.DisplayMember = "Name";
                CBfoldername.ValueMember = "Path";
                FileInfoTable = RepObj.GetFileInfoTable();

            }
            catch (Exception Ex)
            {
                Errorlabel1.Text = Ex.Message;
                ErrrorLog.ErrorlogWrite(Ex);
            }
            SelectedFolders.Items.Clear();
            MessageBox.Show("Run Completed");
        }

        private void CBfoldername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void FileTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            FileTypeButton.Text=RepObj.GetFileTypeCount(FileTypeComboBox.SelectedItem.ToString());
        }

        private void FileTypeButton_Click(object sender, EventArgs e)
        {
            if (FileTypeComboBox.SelectedItem.ToString() == "")
            {
                Label errorlbl = new Label();
                errorlbl.Text = "plz select any filetype";
            }
            else
            {
                DataRow[] DataRows = FileInfoTable.Select("Type='" + FileTypeComboBox.SelectedItem.ToString() + "'");
                ReportDataSource reportDataSource = new ReportDataSource("Data", FileInfoTable);



                string exeFolder = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

                reportViewer1.LocalReport.ReportPath = exeFolder + @"\Report1.rdlc";


                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                //_reportViewer.ServerReport.SetParameters(report);

                reportViewer1.RefreshReport();

                reportViewer1.Refresh();
                reportViewer1.Show();
            }
           
        }

        private void UnsupportedButton_Click(object sender, EventArgs e)
        {

        }
    }
}

