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


        public string getdata(string Typeofinfo,string Monthvalue)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ("Data Source=ACUPC-0906;Initial Catalog=FolderUpload;Integrated Security=True");
                connection.Open();
                string query = "(select count("+ Typeofinfo + ") from FileInfo f where DATEDIFF(month,f."+Typeofinfo+",GETDATE())<"+Monthvalue+ ")";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    value = dr[0].ToString();
                }
                connection.Close();
                return value;
            }
        }
        public DataSet RetreiveToGrid(string TypeOfInfo, string DisplayMonths)
        {
            DataSet dset;
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ("Data Source=ACUPC-0906;Initial Catalog=FolderUpload;Integrated Security=True");
                connection.Open();
                string query = "(select * from FileInfo f where DATEDIFF(month,"+TypeOfInfo+",GETDATE())<" + DisplayMonths + ")";
                SqlCommand command = new SqlCommand(query, connection);


                using (SqlDataAdapter sda = new SqlDataAdapter(command))
                {
                    using (dset = new DataSet())
                    {
                        sda.Fill(dset, "FileInfo");
                    }
                }
               
            }
            return dset;
        }
       
    }
}

