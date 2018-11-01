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
        public Main()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            Repository rp = new Repository();
            comboBox2.Text = rp.monthvalue.ToString();
            label3.Text = comboBox1.SelectedItem.ToString();
            
            switch (label3.Text)
            {
                case "Accessed":
                    int value12 = Convert.ToInt32(comboBox2.SelectedItem.ToString());
                    rp.Accessed(value12);
                    break;
                case "Modified":
                    rp.Modified(Convert.ToInt32(comboBox2.SelectedItem.ToString()));
                    break;
                case "Created":
                    int returnvalue=rp.Created(Convert.ToInt32(comboBox2.SelectedItem.ToString()));
                    break;
            }

            //if (label3.Text == "Accessed"&&comboBox2.Text=="1 Week")
            //{
            //    CountBox.Text = rp.Accessed();
            //}
            //if (label3.Text == "Created"&&comboBox2.Text=="1 Months")
            //{
            //    CountBox.Text = rp.Created();
            //}
            //if (label3.Text == "Modified"&&comboBox2.Text=="3 Months")
            //{
            //    CountBox.Text = rp.Modified();
            //}
            
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
