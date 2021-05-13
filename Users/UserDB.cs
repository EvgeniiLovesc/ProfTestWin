using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace NK_TEST.Users
{
    class UserDB
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        
        public int id;
        public string name;
        public string last_name;
        public string middle_name;
        public string login;
        public string password;
        public string register_time;
        public int register_method_id;
        public int block;
        public int organization_id;
        public string comment;
        public string phone;
        public string email;
        public string address;
        public int confirmed;
        public string photo_url;
        public int group_id;
        public int type_user;

        public UserDB() { }

        public UserDB(int id_user) 
        {
            this.id = id_user;
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM users WHERE id = " + id_user.ToString();
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    this.name = dataReader.GetValue(1).ToString();
                    this.last_name = dataReader.GetValue(2).ToString();
                    this.middle_name = dataReader.GetValue(3).ToString();
                    this.login = dataReader.GetValue(4).ToString();
                    this.password = dataReader.GetValue(5).ToString();
                    this.register_time = dataReader.GetValue(6).ToString();
                    this.register_method_id = Convert.ToInt32(dataReader.GetValue(7)); //
                    this.block = Convert.ToInt32(dataReader.GetValue(8));
                    this.organization_id = Convert.ToInt32(dataReader.GetValue(9)); //organization_name()
                    this.comment = dataReader.GetValue(10).ToString();
                    this.phone = dataReader.GetValue(11).ToString();
                    this.email = dataReader.GetValue(12).ToString();
                    this.address = dataReader.GetValue(13).ToString();
                    this.confirmed = Convert.ToInt32(dataReader.GetValue(14));
                    this.photo_url = dataReader.GetValue(15).ToString();
                    this.group_id = Convert.ToInt32(dataReader.GetValue(16)); // group_name()
                    this.type_user = Convert.ToInt32(dataReader.GetValue(17));  
                }
                connection.Close();
            }
            catch (Exception ex) { }


        }

        public UserDB(string login) 
        {
            this.login = login;
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM users WHERE login = '" + login + "';";
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    this.id = Convert.ToInt32(dataReader.GetValue(0));
                    this.name = dataReader.GetValue(1).ToString();
                    this.last_name = dataReader.GetValue(2).ToString();
                    this.middle_name = dataReader.GetValue(3).ToString();
                    this.login = dataReader.GetValue(4).ToString();
                    this.password = dataReader.GetValue(5).ToString();
                    this.register_time = dataReader.GetValue(6).ToString();
                    this.register_method_id = Convert.ToInt32(dataReader.GetValue(7)); //
                    this.block = Convert.ToInt32(dataReader.GetValue(8));
                    this.organization_id = Convert.ToInt32(dataReader.GetValue(9)); //organization_name()
                    this.comment = dataReader.GetValue(10).ToString();
                    this.phone = dataReader.GetValue(11).ToString();
                    this.email = dataReader.GetValue(12).ToString();
                    this.address = dataReader.GetValue(13).ToString();
                    this.confirmed = Convert.ToInt32(dataReader.GetValue(14));
                    this.photo_url = dataReader.GetValue(15).ToString();
                    this.group_id = Convert.ToInt32(dataReader.GetValue(16)); // group_name()
                    this.type_user = Convert.ToInt32(dataReader.GetValue(17));  
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

        public UserDB(string name, string last_name, string middle_name, string login, string password, string register_time, int register_method_id, int block, int organization_id, string comment, string phone, string email, string address, 
            int confirmed, string photo_url, int group_id, int type_user)
        {
            this.name = name;
            this.last_name = last_name;
            this.middle_name = middle_name;
            this.login = login;
            this.password = password;
            this.register_time = register_time;
            this.register_method_id = register_method_id;
            this.block = block;
            this.organization_id = organization_id;
            this.comment = comment;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.confirmed = confirmed;
            this.photo_url = photo_url;
            this.group_id = group_id;
            this.type_user = type_user;
            //AddToDB();
        }

        public string group_name()
        {
            string result = "";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM users_group WHERE id = " + this.group_id.ToString();
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
        
        public string organization_name()
        {
            string result = "";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT name FROM organization WHERE id = " + this.organization_id.ToString();
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

        public void AddToDB() 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                
                string sql = "INSERT INTO users(" +
                    "name," +
                    " last_name," +
                    " middle_name," +
                    " login," +
                    " password," +
                    " register_time," +
                    " register_method_id," +
                    " block," +
                    "organization_id," +
                    "comment," +
                    "phone," +
                    "email," +
                    "address," +
                    "confirmed," +
                    "photo_url," +
                    "group_id," +
                    "type_user" +
                    ") VALUES('"
                    + this.name + "', '"
                    + this.last_name + "', '"
                    + this.middle_name + "', '"
                    + this.login + "', '"
                    + this.password + "', '"
                    + this.register_time + "', '"
                    + this.register_method_id + "', '"
                    + this.block + "', '"
                    + this.organization_id + "', '"
                    + this.comment + "', '"
                    + this.phone + "', '"
                    + this.email + "', '"
                    + this.address + "', '"
                    + this.confirmed + "', '"
                    + this.photo_url + "', '"
                    + this.group_id + "', '"
                    + this.type_user.ToString()
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
                
                string sql = "UPDATE users SET " + 
                    "name = '" + this.name + 
                    "', last_name = '" + this.last_name + 
                    "', middle_name = '" + this.middle_name + 
                    "', login = '" + this.login + 
                    "', password = '" + this.password +
                    "', register_time = '" + this.register_time + 
                    "', register_method_id = '" + this.register_method_id +
                    "', block = '" + this.block +
                    "', organization_id = '" + this.organization_id +
                    "', comment = '" + this.comment + 
                    "', phone = '" + this.phone +
                    "', email = '" + this.email +
                    "', address = '" + this.address +
                    "', confirmed = '" + this.confirmed +
                    "', photo_url = '" + this.photo_url +
                    "', group_id = '" + this.group_id +
                    "', type_user = '" + this.type_user.ToString() + 
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
                // Сначала удалим правила пользователя из таблицы rl_users чтобы
                // не было конфлика FK
                string sql_rl_users = "DELETE FROM rl_users WHERE user_id = '" + id.ToString() +  "';";
                SqlCommand command_rl = new SqlCommand(sql_rl_users, connection);
                connection.Open();
                command_rl.ExecuteNonQuery();
                connection.Close();
                // Удалим связанное с юзером из таблицы test_group
                string sql_tests_group = "DELETE FROM tests_group WHERE owner_id = '" + id.ToString() +  "';";
                SqlCommand command_tests_group = new SqlCommand(sql_tests_group, connection);
                connection.Open();
                command_tests_group.ExecuteNonQuery();
                connection.Close();
                //Удалим связанное с юзером из таблицы result
                string sql_result= "DELETE FROM result WHERE user_id = '" + id.ToString() +  "';";
                SqlCommand command_result = new SqlCommand(sql_result, connection);
                connection.Open();
                command_result.ExecuteNonQuery();
                connection.Close();
                //Удалим связанное с юзером из таблицы user_tests
                string sql_user_tests= "DELETE FROM users_tests WHERE user_id = '" + id.ToString() +  "';";
                SqlCommand command_user_tests = new SqlCommand(sql_user_tests, connection);
                connection.Open();
                command_user_tests.ExecuteNonQuery();
                connection.Close();
                //Удалим связанное с юзером из таблицы user_logs
                string sql_user_logs= "DELETE FROM user_logs WHERE user_id = '" + id.ToString() +  "';";
                SqlCommand command_user_logs = new SqlCommand(sql_user_logs, connection);
                connection.Open();
                command_user_logs.ExecuteNonQuery();
                connection.Close();
                // Далее удалим самого юзера
                string sql = "DELETE FROM users WHERE id = '" + id.ToString() +  "';";
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


        


    }

}
