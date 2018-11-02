using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using UploadFolderDAL;
using System.Windows.Forms;

namespace UploadFolder
{
    public partial class Main : Form
    {
        Repository rp = new Repository();
        public Main()
        {
            InitializeComponent();
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("CreatedOn", "Created");
            test.Add("ModifiedOn", "Modified");
            test.Add("FileAccessed", "Accesed");
            InformationBox.DataSource = new BindingSource(test, null);
            InformationBox.DisplayMember = "Value";
            InformationBox.ValueMember = "Key";
            MonthsBox.SelectedItem = "1";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

         
            SelectedInfoLabel.Text = InformationBox.SelectedItem.ToString();
            SelectedInfoLabel.Text = InformationBox.SelectedValue.ToString();
            SelectedInfoLabel.Visible = true;
            DisplayGridButton.Visible = true;
            DisplayGridButton.Text=rp.getdata(InformationBox.SelectedValue.ToString(),MonthsBox.SelectedItem.ToString()); 
        }

        private void DisplayGrid_Click(object sender, EventArgs e)
        {
            this.DataGridView.Visible = true;
            DataSet dset = rp.RetreiveToGrid(InformationBox.SelectedValue.ToString(), MonthsBox.SelectedItem.ToString());
            DataGridView.DataSource = dset.Tables["FileInfo"];          
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
