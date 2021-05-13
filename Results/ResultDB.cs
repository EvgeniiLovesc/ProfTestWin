using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using NK_TEST.Users;

namespace NK_TEST.Results
{
    public class ResultDB
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public int id;
        public int user_id;
        public int test_id;
        public string date;
        public string time;
        //public DateTime date;
        //public DateTime time;
        public string status;
        public int value;
        public string result;

        public ResultDB() 
        {
        }        
        
        public ResultDB(int id, int user_id, int test_id, string date, string time, string status, int value, string result) 
        {
            this.id = id;
            this.user_id = user_id;
            this.test_id = test_id;
            this.date = date;
            this.time = time;
            this.status = status;
            this.value = value;
            this.result = result;
        }

        public string user_name()
        {
            string user_name = "";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT name FROM users WHERE id = " + this.user_id.ToString();
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    user_name = dataReader.GetValue(0).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                user_name = "";
            }
            
            return user_name; 
        }

        public string user_sername()
        {
            string user_name = "";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT last_name FROM users WHERE id = " + this.user_id.ToString();
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    user_name = dataReader.GetValue(0).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                user_name = "";
            }
            
            return user_name; 
        }

        public string user_middlename()
        {
            string user_name = "";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT middle_name FROM users WHERE id = " + this.user_id.ToString();
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    user_name = dataReader.GetValue(0).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                user_name = "";
            }
            
            return user_name; 
        }

        public string user_groupname()
        {
            string result = "";
            string group_id = "";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                // ВРЕМЕННО
                string sql = "SELECT group_id FROM users WHERE id = " + this.user_id.ToString();
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    group_id = dataReader.GetValue(0).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                result = "";
            }
            
            SqlConnection connection2 = new SqlConnection(connectionString);
            try
            {
                connection2.Open();
                SqlDataReader dataReader2;
                // ВРЕМЕННО
                string sql2 = "SELECT * FROM users_group WHERE id = " + group_id;
                SqlCommand command = new SqlCommand(sql2, connection2);
                dataReader2 = command.ExecuteReader();
                while (dataReader2.Read())
                {
                    result = dataReader2.GetValue(1).ToString();
                }
                connection2.Close();
            }
            catch (Exception ex)
            {
                result = "";
            }

            return result; 
        }

        public string test_name()
        {
            string result = "";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                // ВРЕМЕННО
                string sql = "SELECT name FROM tests WHERE id = " + this.test_id.ToString();
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    result = dataReader.GetValue(0).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                result = "";
            }
            
            return result; 
        }

        public ResultDB getById(int id) 
        {            
            return this;
        }

        public void Save() 
        {
        
        }

    }
}
