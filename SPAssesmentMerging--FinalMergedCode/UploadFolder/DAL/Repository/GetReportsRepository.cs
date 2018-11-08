using System;
using System.Data;
using System.Data.SqlClient;
using DAL.Model;
using DAL.Repository;

namespace DAL
{
    public class GetReportsRepository
    {
        string databaselink = ConnectionString.Constr;
        string value;
        // public int monthvalue;
        public string Getdata(string Typeofinfo, string Monthvalue)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {

                    connection.ConnectionString = (databaselink);
                    connection.Open();
                   
                    string query = "(select count(" + Typeofinfo + ") from FileInfo f where DATEDIFF(month,f." + Typeofinfo + ",GETDATE())<" + Monthvalue + ")";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        value = dataReader[0].ToString();
                    }
                   
                    return value;
                }
            }
            catch (Exception Ex)
            {
                ErrrorLog.ErrorlogWrite(Ex);
                return null;
            }



        }
        public DataTable GetFileType()
        {
            //DataSet dataSet;
            DataTable Dt;
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = databaselink;
                connection.Open();
                string query = "select distinct Type from FileInfo";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    Dt = new DataTable();

                    dataAdapter.Fill(Dt);

                }

            }
            return Dt;
        }
        public DataTable GetFileInfoTable()
        {
           
            DataTable Dt;
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = databaselink;
                connection.Open();
                string query = "select * from FileInfo";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    Dt = new DataTable();

                    dataAdapter.Fill(Dt);

                }

            }
            return Dt;
        }


        public DataSet GetInformationToRpt(string TypeOfInfo, string DisplayMonths)
        {
           
            DataSet dataset;
            using (SqlConnection connection = new SqlConnection())
            {
               
                connection.ConnectionString = databaselink;
                connection.Open();
                string query = "(select * from FileInfo f where DATEDIFF(month," + TypeOfInfo + ",GETDATE())<" + DisplayMonths + ")";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    dataset = new DataSet();

                    dataAdapter.Fill(dataset);
                  
                }
                return dataset;
            }
        
            
        }
      

        public string GetFileTypeCount(string fileType)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = (databaselink);
                    connection.Open();
                    string query = "select count(Type) from FileInfo where Type='"+fileType+"'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        value = dataReader[0].ToString();
                    }

                    return value;
                }
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public string GetUnsupportedFiles()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = (databaselink);
                    connection.Open();
                    string query = "(select count(IsFileUnsupported) from FileInfo f where IsFileUnsupported=0 )";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        value = dataReader[0].ToString();
                    }
                }
                return value;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }

}

