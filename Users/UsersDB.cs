using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace NK_TEST.Users
{
    class UsersDB
    {
        public List<UserDB> objects;
        public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public int number;
        private int group_id_show;

        public UsersDB(){}   

        public void Fill()
        {
            List<UserDB> list_objects = new List<UserDB>();  
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM users ORDER BY group_id";
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                this.number = 0;
                while (dataReader.Read())
                {
                    UserDB obj = new UserDB();
                    obj.id = Convert.ToInt32(dataReader.GetValue(0));
                    obj.name = Convert.ToString(dataReader.GetValue(1));
                    obj.last_name = Convert.ToString(dataReader.GetValue(2));
                    obj.middle_name = Convert.ToString(dataReader.GetValue(3));
                    obj.login = Convert.ToString(dataReader.GetValue(4));
                    obj.password = Convert.ToString(dataReader.GetValue(5));
                    obj.register_time = Convert.ToString(dataReader.GetValue(6));
                    obj.register_method_id = Convert.ToInt32(dataReader.GetValue(7));
                    obj.block = Convert.ToInt32(dataReader.GetValue(8));
                    obj.organization_id = Convert.ToInt32(dataReader.GetValue(9));
                    obj.comment = Convert.ToString(dataReader.GetValue(10));
                    obj.phone = Convert.ToString(dataReader.GetValue(11));
                    obj.email = Convert.ToString(dataReader.GetValue(12));
                    obj.address = Convert.ToString(dataReader.GetValue(13));
                    obj.confirmed = Convert.ToInt32(dataReader.GetValue(14));
                    obj.photo_url = Convert.ToString(dataReader.GetValue(15));
                    
                    if (Convert.ToInt32(dataReader.GetValue(16)) == this.group_id_show)
                    { 
                        
                    } 
                    else
                    {
                        obj.group_id = obj.group_id = Convert.ToInt32(dataReader.GetValue(16));
                        this.group_id_show = obj.group_id;
                    }  
                    obj.type_user = Convert.ToInt32(dataReader.GetValue(17));
                  
                    list_objects.Add(obj);
                    this.number += 1;
                    obj = null;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                this.number = 0;
            }

            objects = list_objects;            
        }

        public void Fill(int group_id)
        {
            List<UserDB> list_objects = new List<UserDB>();  
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM users WHERE group_id = '" + group_id.ToString() + "' ORDER BY group_id";
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                this.number = 0;
                while (dataReader.Read())
                {
                    UserDB obj = new UserDB();
                    obj.id = Convert.ToInt32(dataReader.GetValue(0));
                    obj.name = Convert.ToString(dataReader.GetValue(1));
                    obj.last_name = Convert.ToString(dataReader.GetValue(2));
                    obj.middle_name = Convert.ToString(dataReader.GetValue(3));
                    obj.login = Convert.ToString(dataReader.GetValue(4));
                    obj.password = Convert.ToString(dataReader.GetValue(5));
                    obj.register_time = Convert.ToString(dataReader.GetValue(6));
                    obj.register_method_id = Convert.ToInt32(dataReader.GetValue(7));
                    obj.block = Convert.ToInt32(dataReader.GetValue(8));
                    obj.organization_id = Convert.ToInt32(dataReader.GetValue(9));
                    obj.comment = Convert.ToString(dataReader.GetValue(10));
                    obj.phone = Convert.ToString(dataReader.GetValue(11));
                    obj.email = Convert.ToString(dataReader.GetValue(12));
                    obj.address = Convert.ToString(dataReader.GetValue(13));
                    obj.confirmed = Convert.ToInt32(dataReader.GetValue(14));
                    obj.photo_url = Convert.ToString(dataReader.GetValue(15));
                    
                    if (Convert.ToInt32(dataReader.GetValue(16)) == this.group_id_show)
                    {                         
                    } 
                    else
                    {
                        obj.group_id = obj.group_id = Convert.ToInt32(dataReader.GetValue(16));
                        this.group_id_show = obj.group_id;
                    }  
                    obj.type_user = Convert.ToInt32(dataReader.GetValue(17));
                  
                    list_objects.Add(obj);
                    this.number += 1;
                    obj = null;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                this.number = 0;
            }

            objects = list_objects;            
        }

        public void FillByGroupId(int group_id)
        {
            List<UserDB> list_objects = new List<UserDB>();  
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM users WHERE group_id = '" + group_id.ToString() + "';";
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                this.number = 0;
                while (dataReader.Read())
                {
                    UserDB obj = new UserDB();
                    obj.id = Convert.ToInt32(dataReader.GetValue(0));
                    obj.name = Convert.ToString(dataReader.GetValue(1));
                    obj.last_name = Convert.ToString(dataReader.GetValue(2));
                    obj.middle_name = Convert.ToString(dataReader.GetValue(3));
                    obj.login = Convert.ToString(dataReader.GetValue(4));
                    obj.password = Convert.ToString(dataReader.GetValue(5));
                    obj.register_time = Convert.ToString(dataReader.GetValue(6));
                    obj.register_method_id = Convert.ToInt32(dataReader.GetValue(7));
                    obj.block = Convert.ToInt32(dataReader.GetValue(8));
                    obj.organization_id = Convert.ToInt32(dataReader.GetValue(9));
                    obj.comment = Convert.ToString(dataReader.GetValue(10));
                    obj.phone = Convert.ToString(dataReader.GetValue(11));
                    obj.email = Convert.ToString(dataReader.GetValue(12));
                    obj.address = Convert.ToString(dataReader.GetValue(13));
                    obj.confirmed = Convert.ToInt32(dataReader.GetValue(14));
                    obj.photo_url = Convert.ToString(dataReader.GetValue(15));
                    obj.group_id = Convert.ToInt32(dataReader.GetValue(16));
                    obj.type_user = Convert.ToInt32(dataReader.GetValue(17));
                  
                    list_objects.Add(obj);
                    this.number += 1;
                    obj = null;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                this.number = 0;
            }

            objects = list_objects;            
        }

        public void DeleteByGroupId(int group_id) 
        {
            this.FillByGroupId(group_id);
            
            foreach (UserDB user in objects) 
            {
                Delete(user.id);
            }        
        }

        public void MoveToGroupId(int group_from_id, int group_to_id) 
        {
            this.FillByGroupId(group_from_id);
            
            foreach (UserDB user in objects) 
            {
                Move(user.id, group_to_id);
            }           
        
        }

        public void DeleteList(List <int> users_id) 
        {
            foreach (int user_id in users_id) 
            {
                Delete(user_id);
            }
        
        }

        public void Delete(int id) 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                
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

        public void Move(int user_id, int group_id_to) 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {

                string sql = "UPDATE users SET group_id = '" + group_id_to.ToString() + "' WHERE id = '" + user_id.ToString()  + "';";
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
