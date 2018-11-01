using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UploadFolderDAL
{
    public class Repository
    {
        public static int count;
        string value;
        public int monthvalue;
                   
        public string  Accessed(int UpTo)
        {
            count = 0;
            using (SqlConnection connection = new SqlConnection())
            {
                
                connection.ConnectionString = ("Data Source=ACUPC-0906;Initial Catalog=FolderUpload;Integrated Security=True");
                connection.Open();
                string query = "select count(*) from FileInfo f where DATEDIFF(month,f.CreatedOn,GETDATE())<monthvalue";  
                SqlCommand command = new SqlCommand(query, connection);               
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    value = dr[0].ToString();
                    
                }
                connection.Close();
            }

            return value;
        }
        public string Created(int UpTo)
        {
            count = 0;
            using (SqlConnection connection = new SqlConnection())
            {

                connection.ConnectionString = ("Data Source=ACUPC-0906;Initial Catalog=FolderUpload;Integrated Security=True");
                connection.Open();
                string query = "select count(*) from FileInfo f where DATEDIFF(month,f.CreatedOn,GETDATE())<UpTo";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    value = dr[0].ToString();

                }
                connection.Close();
            }

            return value;
        }

        public string Modified(int UpTo)
        {
            count = 0;
            using (SqlConnection connection = new SqlConnection())
            {

                connection.ConnectionString = ("Data Source=ACUPC-0906;Initial Catalog=FolderUpload;Integrated Security=True");
                connection.Open();
                string query = "select count(*) from FileInfo f where DATEDIFF(month,f.CreatedOn,GETDATE())<UpTo";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    value = dr[0].ToString();

                }
                connection.Close();
            }

            return value;
        }
        public void BindGrid()
        {
            string constring = @"Data Source=.\SQL2005;Initial Catalog=Northwind;User id = sa;password=pass@123";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}

