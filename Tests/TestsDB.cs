using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NK_TEST.Tests
{
    class TestsDB
    {
        public List<TestDB> objects;
        public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public int number;
        private int group_id_show;

        public TestsDB() { }   

        public void Fill()
        {
            List<TestDB> list_objects = new List<TestDB>();  
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM tests ORDER BY group_id DESC";
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                this.number = 0;
                while (dataReader.Read())
                {
                    TestDB obj = new TestDB();
                    obj.id = Convert.ToInt32(dataReader.GetValue(0));
                    obj.name = dataReader.GetValue(1).ToString();
                    obj.owner_id = Convert.ToInt32(dataReader.GetValue(2));
                    obj.description = dataReader.GetValue(3).ToString();
                    obj.date_created = Convert.ToDateTime(dataReader.GetValue(4)); 
                    obj.date_last_saved = Convert.ToDateTime(dataReader.GetValue(5)); 
                    obj.number_groups = Convert.ToInt32(dataReader.GetValue(6));
                    obj.number_questions = Convert.ToInt32(dataReader.GetValue(7));
                    obj.number_messages = Convert.ToInt32(dataReader.GetValue(8));
                    obj.number_scale = Convert.ToInt32(dataReader.GetValue(9));
                    obj.number_test_version = Convert.ToInt32(dataReader.GetValue(10));
                    obj.number_results = Convert.ToInt32(dataReader.GetValue(11));
                    obj.instructions = dataReader.GetValue(12).ToString();
                    obj.display_instructions = Convert.ToInt32(dataReader.GetValue(13));
                    obj.type = dataReader.GetValue(14).ToString();
                    obj.navi_true_get_back_questions = Convert.ToInt32(dataReader.GetValue(15));
                    obj.navi_true_skip_questions = Convert.ToInt32(dataReader.GetValue(16));
                    obj.navi_block_finish_test_before_get_all_answers = Convert.ToInt32(dataReader.GetValue(17));
                    obj.time_true_endless = Convert.ToInt32(dataReader.GetValue(18));
                    obj.time_true_limited = Convert.ToInt32(dataReader.GetValue(19));
                    obj.time_limit_value = dataReader.GetValue(20).ToString();
                    obj.blend_no_blend = Convert.ToInt32(dataReader.GetValue(21));
                    obj.blend_individual = Convert.ToInt32(dataReader.GetValue(22));
                    obj.blend_all_questions = Convert.ToInt32(dataReader.GetValue(23));
                    obj.descript_display_for_test_time = Convert.ToInt32(dataReader.GetValue(24));
                    obj.descript_display_for_error = Convert.ToInt32(dataReader.GetValue(25));
                    obj.result_display_error_after_test = Convert.ToInt32(dataReader.GetValue(26));
                    obj.result_display_rigth_answer = Convert.ToInt32(dataReader.GetValue(27));

                    if (Convert.ToInt32(dataReader.GetValue(28)) == this.group_id_show)
                    {                         
                    } 
                    else
                    {
                        obj.group_id = Convert.ToInt32(dataReader.GetValue(28));
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
                MessageBox.Show("Ошибка загрузки тестов в таблицу:" + ex.Message);
            }

            objects = list_objects;            
        }

        public void Fill(int group_id)
        {
            List<TestDB> list_objects = new List<TestDB>();  
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM tests WHERE group_id = '" + group_id.ToString() + "';";
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                this.number = 0;
                while (dataReader.Read())
                {
                    TestDB obj = new TestDB();
                    obj.id = Convert.ToInt32(dataReader.GetValue(0));
                    obj.name = dataReader.GetValue(1).ToString();
                    obj.owner_id = Convert.ToInt32(dataReader.GetValue(2));
                    obj.description = dataReader.GetValue(3).ToString();
                    obj.date_created = Convert.ToDateTime(dataReader.GetValue(4)); 
                    obj.date_last_saved = Convert.ToDateTime(dataReader.GetValue(5)); 
                    obj.number_groups = Convert.ToInt32(dataReader.GetValue(6));
                    obj.number_questions = Convert.ToInt32(dataReader.GetValue(7));
                    obj.number_messages = Convert.ToInt32(dataReader.GetValue(8));
                    obj.number_scale = Convert.ToInt32(dataReader.GetValue(9));
                    obj.number_test_version = Convert.ToInt32(dataReader.GetValue(10));
                    obj.number_results = Convert.ToInt32(dataReader.GetValue(11));
                    obj.instructions = dataReader.GetValue(12).ToString();
                    obj.display_instructions = Convert.ToInt32(dataReader.GetValue(13));
                    obj.type = dataReader.GetValue(14).ToString();
                    obj.navi_true_get_back_questions = Convert.ToInt32(dataReader.GetValue(15));
                    obj.navi_true_skip_questions = Convert.ToInt32(dataReader.GetValue(16));
                    obj.navi_block_finish_test_before_get_all_answers = Convert.ToInt32(dataReader.GetValue(17));
                    obj.time_true_endless = Convert.ToInt32(dataReader.GetValue(18));
                    obj.time_true_limited = Convert.ToInt32(dataReader.GetValue(19));
                    obj.time_limit_value = dataReader.GetValue(20).ToString();
                    obj.blend_no_blend = Convert.ToInt32(dataReader.GetValue(21));
                    obj.blend_individual = Convert.ToInt32(dataReader.GetValue(22));
                    obj.blend_all_questions = Convert.ToInt32(dataReader.GetValue(23));
                    obj.descript_display_for_test_time = Convert.ToInt32(dataReader.GetValue(24));
                    obj.descript_display_for_error = Convert.ToInt32(dataReader.GetValue(25));
                    obj.result_display_error_after_test = Convert.ToInt32(dataReader.GetValue(26));
                    obj.result_display_rigth_answer = Convert.ToInt32(dataReader.GetValue(27));

                    if (Convert.ToInt32(dataReader.GetValue(28)) == this.group_id_show)
                    {                         
                    } 
                    else
                    {
                        obj.group_id = Convert.ToInt32(dataReader.GetValue(28));
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
            this.Fill(group_id);
            
            foreach (TestDB user in objects) 
            {
                Delete(user.id);
            }        
        }

        public void MoveToGroupId(int group_from_id, int group_to_id) 
        {
            this.Fill(group_from_id);
            
            foreach (TestDB user in objects) 
            {
                Move(user.id, group_to_id);
            }           
        
        }

        public void Move(int user_id, int group_id_to) 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {

                string sql = "UPDATE tests SET group_id = '" + group_id_to.ToString() + "' WHERE id = '" + user_id.ToString()  + "';";
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
                
                string sql = "DELETE FROM tests WHERE id = '" + id.ToString() +  "';";
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
