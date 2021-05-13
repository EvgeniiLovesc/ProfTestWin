using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NK_TEST.admins
{

    class AdminDB
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        public int id;
        public string name;
        public string last_name;
        public string middle_name;
        public string register_time;
        public string comment;
        public int type_user;
        public string login;
        public string password;

        public AdminDB() { }

        public AdminDB(int id_user)
        {
            this.id = id_user;

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM admins WHERE id = " + id_user.ToString();
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    this.name = dataReader.GetValue(1).ToString();
                    this.last_name = dataReader.GetValue(2).ToString();
                    this.middle_name = dataReader.GetValue(3).ToString();
                    this.register_time = dataReader.GetValue(4).ToString();
                    this.comment = dataReader.GetValue(5).ToString();
                    this.type_user = Convert.ToInt32(dataReader.GetValue(6));                    
                    this.login = dataReader.GetValue(7).ToString();
                    this.password = dataReader.GetValue(8).ToString();
                }
                connection.Close();
            }
            catch (Exception ex) { }
        }

        public AdminDB(string login) 
        {
            this.login = login;
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM admins WHERE login = '" + login + "';";
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    this.id = Convert.ToInt32(dataReader.GetValue(0));
                    this.name = dataReader.GetValue(1).ToString();
                    this.last_name = dataReader.GetValue(2).ToString();
                    this.middle_name = dataReader.GetValue(3).ToString();
                    this.register_time = dataReader.GetValue(4).ToString();
                    this.comment = dataReader.GetValue(5).ToString();
                    this.type_user = Convert.ToInt32(dataReader.GetValue(6));                    
                    this.login = dataReader.GetValue(7).ToString();
                    this.password = dataReader.GetValue(8).ToString();                    
                     
                }
                connection.Close();
            }
            catch (Exception ex) { }


        }

        public bool AuthCheck(string password)
        {
            if (password == this.password)
            {
                return true;
            }
            else 
            {
                return false;
            }
        
        }

        public AdminDB(string name, string last_name, string middle_name, string login, string password, string register_time, string comment, int type_user)
        {
            this.name = name;
            this.last_name = last_name;
            this.middle_name = middle_name;
            this.login = login;
            this.password = password;
            this.register_time = register_time;
            this.comment = comment;
            this.type_user = type_user;
        }

        public void AddToDB() 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                
                string sql = "INSERT INTO admins(name, last_name, middle_name, register_time, comment, type_user, login, password) VALUES('"
                    + this.name + "', '"
                    + this.last_name + "', '"
                    + this.middle_name + "', '"
                    + this.register_time + "', '"
                    + this.comment + "', '"
                    + this.type_user.ToString() + "', '"
                    + this.login + "', '"
                    + this.password
                    + "');";

                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        
        }

        public void Save() 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                
                string sql = "UPDATE admins SET " + 
                    "name = '" + this.name + 
                    "', last_name = '" + this.last_name + 
                    "', middle_name = '" + this.middle_name + 
                    "', register_time = '" + this.register_time + 
                    "', comment = '" + this.comment + 
                    "', type_user = '" + this.type_user.ToString() + 
                    "', login = '" + this.login + 
                    "', password = '" + this.password +
                    "' WHERE id = " + this.id.ToString();

                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        
        }

        public void Delete(int id) 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                
                string sql = "DELETE FROM admins WHERE id = '" + id.ToString() +  "';";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        
        }

        public string get_type_user() 
        {
            string result = "";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM type_user WHERE id = " + this.type_user.ToString();
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    result = dataReader.GetValue(1).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                result = "";
            }

            return result;
        
        }
    }

}
