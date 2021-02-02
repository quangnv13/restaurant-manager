using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant_Manager.DAL
{
    public class Data
    {
        private static Data instance;

        public static Data Instance
        {
            get
            {
                if (instance == null)
                    instance = new Data();
                return Data.instance;
            }
            private set { Data.instance = value; }
        }
        private Data() {  }
        private string connectionSTR = @"Data Source=AHHUNGKNOW-PC\SQLEXPRESS;Initial Catalog=Restaurant_Manager;Integrated Security=True";
        public DataTable ExecuteQuery(string query,object[] Parameters=null)
        {
            DataTable dt=new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (Parameters != null)
                {
                    int i = 0;
                    string[] listParameter = query.Split(' ');
                    foreach (string item in listParameter)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, Parameters[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                connection.Close();
            }
        return dt;
        }
        public int ExecuteNonQuery(string query,object[] Parameters=null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (Parameters != null)
                {
                    int i = 0;
                    string[] listParameter = query.Split(' ');
                    foreach(string item in listParameter)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, Parameters[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query,object[] Parameters=null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if(Parameters!=null)
                {
                    int i = 0;
                    string[] listParameter = query.Split(' ');
                    foreach(string item in listParameter)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, Parameters[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}

