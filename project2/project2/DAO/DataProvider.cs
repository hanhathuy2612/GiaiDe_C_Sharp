using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.DAO
{
    class DataProvider
    {
        // Singlethon

        private static DataProvider instance;

        internal static DataProvider Instance 
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            } 
            private set => instance = value; 
        }

        private string constr = @"Data Source=.\sqlexpress;Initial Catalog=VATLIEUDATA;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using(SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                        
                    }
                }
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                sqlData.Fill(data);
                con.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int kq = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }
                kq = command.ExecuteNonQuery();
                con.Close();
            }
            return kq;
        }
    }
}
