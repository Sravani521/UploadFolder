using System;
using System.Collections.Generic;
using System.Data;
using UploadFolderDAL;
using System.Windows.Forms;

namespace UploadFolder
{
    public partial class Main : Form
    {
        Repository RepObj = new Repository();
        public Main()
        {
            InitializeComponent();   
            Dictionary<string, string> ComboBoxItems = new Dictionary<string, string>();
            //Adding the Items to the combobox
            ComboBoxItems.Add("CreatedOn", "Created");
            ComboBoxItems.Add("ModifiedOn", "Modified");
            ComboBoxItems.Add("FileAccessed", "Accesed");
            //Binding the items
            InformationBox.DataSource = new BindingSource(ComboBoxItems, null);
            InformationBox.DisplayMember = "Value";
            InformationBox.ValueMember = "Key";
            MonthsBox.SelectedItem = "1";
        }
        
        private void DisplayCountButton_Click(object sender, EventArgs e)
        {
            try
            {
                //getting the text from (InformationBox)Combobox to the SelectedInfoLabel 
                SelectedInfoLabel.Text = InformationBox.SelectedItem.ToString();
                SelectedInfoLabel.Text = InformationBox.SelectedValue.ToString();
                SelectedInfoLabel.Visible = true;
                DisplayGridButton.Visible = true;
                //this line of code loads the InformationBox data and MonthsBox data and displays it in the DisplayGridButton
                DisplayGridButton.Text = RepObj.Getdata(InformationBox.SelectedValue.ToString(), MonthsBox.SelectedItem.ToString());
            }
            catch(Exception Ex)
            {
                ErrrorLog.ErrorlogWrite(Ex);
            }
        }

        private void DisplayGrid_Click(object sender, EventArgs e)
        {
            try
            {

                this.DataGridView.Visible = true;
                //retreiving the data from the database and Fill the data to Gridview
                DataSet dataSet = RepObj.DataGrid(InformationBox.SelectedValue.ToString(), MonthsBox.SelectedItem.ToString());
                DataGridView.DataSource = dataSet.Tables["FileInfo"];
            }
            catch(Exception Ex)
            {
                ErrrorLog.ErrorlogWrite(Ex);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'folderUploadDataSet.FileInfo' table. You can move, or remove it, as needed.
            this.fileInfoTableAdapter.Fill(this.folderUploadDataSet.FileInfo);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
