using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using NK_TEST.Tests;
using NK_TEST.Users;

namespace NK_TEST.Rules
{
    class RuleDB
    {

        public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        public int id;
        public string name;
        public string description;
        public int raspisanie_type_id;
        public DateTime time_start; //datetime
        public DateTime time_finish; //datetime
        public int number_attempt;
        public int admin_id;
        public int group_id;



        public RuleDB() { }

        public RuleDB(int id) 
        {
            this.id = id;
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM rules WHERE id = " + id.ToString();
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    this.id = Convert.ToInt32(dataReader.GetValue(0).ToString());
                    this.name = dataReader.GetValue(1).ToString();
                    this.description = dataReader.GetValue(2).ToString();
                    this.raspisanie_type_id = Convert.ToInt32(dataReader.GetValue(3).ToString());
                    this.time_start = Convert.ToDateTime(dataReader.GetValue(4));
                    this.time_finish = Convert.ToDateTime(dataReader.GetValue(5));
                    this.number_attempt = Convert.ToInt32(dataReader.GetValue(6).ToString());
                    this.admin_id = Convert.ToInt32(dataReader.GetValue(7).ToString());
                    this.group_id = Convert.ToInt32(dataReader.GetValue(8).ToString());
                }
                connection.Close();
            }
            catch (Exception ex) { }


        }

        public RuleDB(string name) 
        {
            this.name = name;
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM rules WHERE name = '" + this.name + "';";
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    this.id = Convert.ToInt32(dataReader.GetValue(0));
                    this.name = dataReader.GetValue(1).ToString();
                    this.description = dataReader.GetValue(2).ToString();
                    this.raspisanie_type_id = Convert.ToInt32(dataReader.GetValue(3));
                    this.time_start = Convert.ToDateTime(dataReader.GetValue(4));
                    this.time_finish = Convert.ToDateTime(dataReader.GetValue(5));
                    this.number_attempt = Convert.ToInt32(dataReader.GetValue(6));
                    this.admin_id = Convert.ToInt32(dataReader.GetValue(7));
                    this.group_id = Convert.ToInt32(dataReader.GetValue(8));

                }
                connection.Close();
            }
            catch (Exception ex) { }


        }

        public RuleDB(string name, string description, int raspisanie_type_id, DateTime time_start, DateTime time_finish, int number_attempt, int admin_id, int group_id)
        {
            this.name = name;
            this.description = description;
            this.raspisanie_type_id = raspisanie_type_id;
            this.time_start = time_start;
            this.time_finish = time_finish;
            this.number_attempt = number_attempt;
            this.admin_id = admin_id;
            this.group_id = group_id;

        }

        public string raspisanie_type() 
        {
            string result = "";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM raspisanie_type WHERE id = " + this.raspisanie_type_id.ToString();
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

            // Период времени
            if (this.raspisanie_type_id == 1)
            {
                return result + ", начать " + this.time_start + ", завершить " + this.time_finish;
            }
            // Ежедневно
            else if (this.raspisanie_type_id == 2) 
            {
                return result + ", начать в " + this.time_start.TimeOfDay + ", завершить в " + this.time_finish.TimeOfDay;            
            }
            // Еженедельно
            else if (this.raspisanie_type_id == 3) 
            {
                return result + ", начать в " + this.time_start.TimeOfDay + ", завершить в " + this.time_finish.TimeOfDay;            
            }
            else
            {
                return result;
            }
                

        }

        public string group_name()
        {
            string result = "";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM rules_group WHERE id = " + this.group_id.ToString();
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

        public string test_count()
        {
            string result = "";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT COUNT(*) FROM rl_tests WHERE rules_id = " + this.id.ToString();
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

        public string users_count()
        {
            string result = "";
            int count = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT COUNT(*) FROM rl_users WHERE rules_id = " + this.id.ToString();
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

        public string number_attempt_str() 
        {
            if (this.number_attempt == 10000000) { return "Неограниченно"; }
            else { return number_attempt.ToString(); }
        }

        public void Delete(int id) 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Сначала удалим правила пользователя из таблицы rl_users чтобы
                // не было конфлика FK
                string sql_rl_users = "DELETE FROM rl_users WHERE rules_id = '" + id.ToString() +  "';";
                SqlCommand command_rl = new SqlCommand(sql_rl_users, connection);
                connection.Open();
                command_rl.ExecuteNonQuery();
                connection.Close();

                // Сначала удалим правила пользователя из таблицы rl_tests чтобы
                // не было конфлика FK
                string sql_rl_tests = "DELETE FROM rl_tests WHERE test_id = '" + id.ToString() +  "';";
                SqlCommand command_rl_tests = new SqlCommand(sql_rl_tests, connection);
                connection.Open();
                command_rl.ExecuteNonQuery();
                connection.Close();

                // Далее удалим само правило
                string sql = "DELETE FROM rules WHERE id = '" + id.ToString() +  "';";
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

        public void AddToDB(bool for_test , int group_id)
        {            
            //for_test = true - правило для теста
            //for_test = false - правило для пользователя
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // 1. Создаём правило в таблице rules
                string sql_rules = "INSERT INTO rules(" +
                    "name," +
                    " description," +
                    " raspisanie_type_id," +
                    " time_start," +
                    " time_finish," +
                    " number_attempt," +
                    " admin_id," +
                    " group_id" +
                    ") VALUES('"
                    + this.name + "', '"
                    + this.description + "', '"
                    + this.raspisanie_type_id + "', '"
                    + this.time_start + "', '"
                    + this.time_finish + "', '"
                    + this.number_attempt + "', '"
                    + this.admin_id + "', '"
                    + this.group_id
                    + "');";

                SqlCommand command = new SqlCommand(sql_rules, connection);
                connection.Open();
                command.ExecuteNonQuery();
                // Получим ID только что созданного правила
                RuleDB rdb = new RuleDB(this.name);
                int id_rules = rdb.id;
                rdb = null;

                // 2. Привязываем правило к тестам в таблице rl_tests                
                
                if (for_test == true)
                {
                    // Получаем все id тестов из данной группы
                    TestsDB tests = new TestsDB();
                    tests.Fill(group_id);
                    string sql_rl_tests = "";
                    for (int i=0; i<tests.objects.Count(); i++) 
                    {
                        sql_rl_tests = "INSERT INTO rl_tests(rules_id, test_id) VALUES('"
                            + id_rules + "', '"
                            + tests.objects[i].id.ToString()
                            + "');"; 
                        command = new SqlCommand(sql_rl_tests, connection);
                        command.ExecuteNonQuery(); 
                    }                
                }
                // 2. Привязываем правило к пользователям в таблице rl_users
                if (for_test == false) 
                {
                    // Получаем все id пользователей из данной группы
                    UsersDB users = new UsersDB();
                    users.Fill(group_id);
                    string sql_rl_users = "";
                    for (int i=0; i<users.objects.Count(); i++) 
                    {
                        sql_rl_users = "INSERT INTO rl_users(rules_id, user_id) VALUES('"
                            + id_rules + "', '"
                            + users.objects[i].id.ToString()
                            + "');"; 
                        command = new SqlCommand(sql_rl_users, connection);
                        command.ExecuteNonQuery(); 
                    }  
                
                }                

                connection.Close();
 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }               
        }

        public void AddToDB(bool for_test , List <int> list_id)
        {            
            //for_test = true - правило для теста
            //for_test = false - правило для пользователя
            
            SqlConnection connection = new SqlConnection(connectionString);
            //try
            //{
                // 1. Создаём правило в таблице rules
                string sql_rules = "INSERT INTO rules(" +
                    "name," +
                    " description," +
                    " raspisanie_type_id," +
                    " time_start," +
                    " time_finish," +
                    " number_attempt," +
                    " admin_id," +
                    " group_id" +
                    ") VALUES('"
                    + this.name + "', '"
                    + this.description + "', '"
                    + this.raspisanie_type_id + "', '"
                    + this.time_start + "', '"
                    + this.time_finish + "', '"
                    + this.number_attempt + "', '"
                    + this.admin_id + "', '"
                    + this.group_id
                    + "');";

                SqlCommand command = new SqlCommand(sql_rules, connection);
                connection.Open();
                command.ExecuteNonQuery();
                // Получим ID только что созданного правила
                RuleDB rdb = new RuleDB(this.name);
                int id_rules = rdb.id;
                rdb = null;

                // 2. Привязываем правило к тестам в таблице rl_tests                
                
                if (for_test == true)
                {
                    // Получаем все id тестов из данной группы
                    string sql_rl_tests = "";
                    for (int i=0; i<list_id.Count(); i++) 
                    {
                        sql_rl_tests = "INSERT INTO rl_tests(rules_id, test_id) VALUES('"
                            + id_rules.ToString() + "', '"
                            + list_id[i].ToString()
                            + "');"; 
                        command = new SqlCommand(sql_rl_tests, connection);
                        command.ExecuteNonQuery(); 
                    }                
                }
                // 2. Привязываем правило к пользователям в таблице rl_users
                if (for_test == false) 
                {
                    // Получаем все id пользователей из данной группы
                    string sql_rl_users = "";
                    for (int i=0; i<list_id.Count(); i++) 
                    {
                        sql_rl_users = "INSERT INTO rl_users(rules_id, user_id) VALUES('"
                            + id_rules + "', '"
                            + list_id[i].ToString()
                            + "');"; 
                        command = new SqlCommand(sql_rl_users, connection);
                        command.ExecuteNonQuery(); 
                    }  
                
                }                

                connection.Close();
 

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}               
        }

        public class rl_tests 
        {
            public int id;
            public int rules_id;
            public int test_id;
            public string test_name;
            public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

            public List<rl_tests> objects;


            private string getNameById(int id_test) 
            {
                TestDB obj = new TestDB(id_test);
                return obj.name;
                obj = null;
            }

            public void FillByRulesID(int _rules_id) 
            {
                List<rl_tests> list_objects = new List<rl_tests>();  
            
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    SqlDataReader dataReader;
                    string sql = "SELECT * FROM rl_tests WHERE rules_id = '" + _rules_id.ToString() + "';";
                    SqlCommand command = new SqlCommand(sql, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        rl_tests obj = new rl_tests();
                        obj.id = Convert.ToInt32(dataReader.GetValue(0));
                        obj.rules_id = Convert.ToInt32(dataReader.GetValue(1));
                        obj.test_id = Convert.ToInt32(dataReader.GetValue(2));
                        obj.test_name = getNameById(obj.test_id);
                  
                        list_objects.Add(obj);
                        obj = null;
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                }

                objects = list_objects;
             }
        }

        public class rl_users 
        {
            public int id;
            public int rules_id;
            public int user_id;
            public string user_name;
            public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

            public List<rl_users> objects;


            private string getNameById(int id_user) 
            {
                UserDB obj = new UserDB(id_user);
                return obj.last_name;
                obj = null;
            }

            public void FillByRulesID(int _rules_id) 
            {
                List<rl_users> list_objects = new List<rl_users>();  
            
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    SqlDataReader dataReader;
                    string sql = "SELECT * FROM rl_users WHERE rules_id = '" + _rules_id.ToString() + "';";
                    SqlCommand command = new SqlCommand(sql, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        rl_users obj = new rl_users();
                        obj.id = Convert.ToInt32(dataReader.GetValue(0));
                        obj.rules_id = Convert.ToInt32(dataReader.GetValue(1));
                        obj.user_id = Convert.ToInt32(dataReader.GetValue(2));
                        obj.user_name = getNameById(obj.user_id);
                        list_objects.Add(obj);
                        obj = null;
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                }

                objects = list_objects;
            }


        }

        public void Save() 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                
                string sql = "UPDATE rules SET " + 
                    "name = '" + this.name + 
                    "', description = '" + this.description + 
                    "', raspisanie_type_id = '" + this.raspisanie_type_id + 
                    "', time_start = '" + this.time_start + 
                    "', time_finish = '" + this.time_finish + 
                    "', number_attempt = '" + this.number_attempt + 
                    "', admin_id = '" + this.admin_id +
                    "', group_id = '" + this.group_id +
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



    }
}
