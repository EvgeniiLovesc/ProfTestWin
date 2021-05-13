using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NK_TEST.Rules
{
    class RulesDB
    {
        public List<RuleDB> objects;
        public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public int number;
        private int group_id_show;

        public void Fill()
        {            
            List<RuleDB> list_objects = new List<RuleDB>();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM rules ORDER BY group_id";
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                this.number = 0;
                while (dataReader.Read())
                {
                    RuleDB obj = new RuleDB();
                    obj.id = Convert.ToInt32(dataReader.GetValue(0));
                    obj.name = Convert.ToString(dataReader.GetValue(1));
                    obj.description = Convert.ToString(dataReader.GetValue(2));
                    obj.raspisanie_type_id = Convert.ToInt32(dataReader.GetValue(3)); 
                    obj.time_start = Convert.ToDateTime(dataReader.GetValue(4));
                    obj.time_finish = Convert.ToDateTime(dataReader.GetValue(5));
                    obj.number_attempt = Convert.ToInt32(dataReader.GetValue(6));
                    obj.admin_id = Convert.ToInt32(dataReader.GetValue(7));
                    if (Convert.ToInt32(dataReader.GetValue(8)) == this.group_id_show)
                    { 
                        
                    } 
                    else
                    {
                        obj.group_id = Convert.ToInt32(dataReader.GetValue(8));
                        this.group_id_show = obj.group_id;
                    }    
                    
                  
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

        public void Delete(int id) 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                
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

        public void FillByGroupId(int group_id)
        {
            List<RuleDB> list_objects = new List<RuleDB>();  
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM rules WHERE group_id = '" + group_id.ToString() + "';";
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                this.number = 0;
                while (dataReader.Read())
                {
                    RuleDB obj = new RuleDB();
                    obj.id = Convert.ToInt32(dataReader.GetValue(0));
                    obj.name = Convert.ToString(dataReader.GetValue(1));
                    obj.description = Convert.ToString(dataReader.GetValue(2)); 
                    obj.raspisanie_type_id = Convert.ToInt32(dataReader.GetValue(3)); 
                    obj.time_start = Convert.ToDateTime(dataReader.GetValue(4)); 
                    obj.time_finish = Convert.ToDateTime(dataReader.GetValue(5)); 
                    obj.number_attempt = Convert.ToInt32(dataReader.GetValue(6)); 
                    obj.admin_id = Convert.ToInt32(dataReader.GetValue(7)); 
                    if (Convert.ToInt32(dataReader.GetValue(8)) == this.group_id_show)
                    {                        
                    } 
                    else
                    {
                        obj.group_id = Convert.ToInt32(dataReader.GetValue(8));
                        this.group_id_show = obj.group_id;
                    }  
                  
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
            
            foreach (RuleDB user in objects) 
            {
                Delete(user.id);
            }        
        }

        public void Move(int user_id, int group_id_to) 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {

                string sql = "UPDATE rules SET group_id = '" + group_id_to.ToString() + "' WHERE id = '" + user_id.ToString()  + "';";
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

        public void MoveToGroupId(int group_from_id, int group_to_id) 
        {
            this.FillByGroupId(group_from_id);
            
            foreach (RuleDB user in objects) 
            {
                Move(user.id, group_to_id);
            }           
        
        }




    }
}
