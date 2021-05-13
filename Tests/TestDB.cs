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
    class TestDB
    {

        public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        public int    id;
        public string name;
        public int    owner_id;
        public string description;
        public DateTime date_created; //datetime
        public DateTime date_last_saved; //datetime
        public int    number_groups;
        public int    number_questions;
        public int    number_messages;
        public int    number_scale;
        public int    number_test_version;
        public int    number_results;
        public string instructions;
        public int    display_instructions;
        public string type;
        public int    navi_true_get_back_questions;
        public int    navi_true_skip_questions;
        public int    navi_block_finish_test_before_get_all_answers;
        public int    time_true_endless;
        public int    time_true_limited;
        public string time_limit_value; //datetime
        public int    blend_no_blend;
        public int    blend_individual;
        public int    blend_all_questions;
        public int    descript_display_for_test_time;
        public int    descript_display_for_error;
        public int    result_display_error_after_test;
        public int    result_display_rigth_answer;
        public int    group_id;

        public List<Question> questions_list = new List<Question>();

        public TestDB(
            string name,
            int owner_id,
            string description,
            DateTime date_created, 
            DateTime date_last_saved,
            int number_groups,
            int number_questions,
            int number_messages,
            int number_scale,
            int number_test_version,
            int number_results,
            string instructions,
            int display_instructions,
            string type,
            int navi_true_get_back_questions,
            int navi_true_skip_questions,
            int navi_block_finish_test_before_get_all_answers,
            int time_true_endless,
            int time_true_limited,
            string time_limit_value,
            int blend_no_blend,
            int blend_individual,
            int blend_all_questions,
            int descript_display_for_test_time,
            int descript_display_for_error,
            int result_display_error_after_test,
            int result_display_rigth_answer,
            int group_id
            )     
        {
        
             this.name = name;
             this.owner_id = owner_id;
             this.description = description;
             this.date_created = date_created;
             this.date_last_saved = date_last_saved; 
             this.number_groups = number_groups;
             this.number_questions = number_questions;
             this.number_messages = number_messages;
             this.number_scale = number_scale;
             this.number_test_version = number_test_version;
             this.number_results = number_results;
             this.instructions = instructions;
             this.display_instructions = display_instructions;
             this.type = type;
             this.navi_true_get_back_questions = navi_true_get_back_questions;
             this.navi_true_skip_questions = navi_true_skip_questions;
             this.navi_block_finish_test_before_get_all_answers = navi_block_finish_test_before_get_all_answers;
             this.time_true_endless = time_true_endless;
             this.time_true_limited = time_true_limited;
             this.time_limit_value = time_limit_value; 
             this.blend_no_blend = blend_no_blend;
             this.blend_individual = blend_individual;
             this.blend_all_questions = blend_all_questions;
             this.descript_display_for_test_time = descript_display_for_test_time;
             this.descript_display_for_error = descript_display_for_error;
             this.result_display_error_after_test = result_display_error_after_test;
             this.result_display_rigth_answer = result_display_rigth_answer;
             this.group_id = group_id;           
        }

        public TestDB(int id_test) 
        {
            this.id = id_test;
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM tests WHERE id = " + id_test.ToString();
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                   this.id = Convert.ToInt32(dataReader.GetValue(0));
                   this.name = dataReader.GetValue(1).ToString();
                   this.owner_id = Convert.ToInt32(dataReader.GetValue(2));
                   this.description = dataReader.GetValue(3).ToString();
                   this.date_created = Convert.ToDateTime(dataReader.GetValue(4)); 
                   this.date_last_saved = Convert.ToDateTime(dataReader.GetValue(5).ToString()); 
                   this.number_groups = Convert.ToInt32(dataReader.GetValue(6));
                   this.number_questions = Convert.ToInt32(dataReader.GetValue(7));
                   this.number_messages = Convert.ToInt32(dataReader.GetValue(8));
                   this.number_scale = Convert.ToInt32(dataReader.GetValue(9));
                   this.number_test_version = Convert.ToInt32(dataReader.GetValue(10));
                   this.number_results = Convert.ToInt32(dataReader.GetValue(11));
                   this.instructions = dataReader.GetValue(12).ToString();
                   this.display_instructions = Convert.ToInt32(dataReader.GetValue(13));
                   this.type = dataReader.GetValue(14).ToString();
                   this.navi_true_get_back_questions = Convert.ToInt32(dataReader.GetValue(15));
                   this.navi_true_skip_questions = Convert.ToInt32(dataReader.GetValue(16));
                   this.navi_block_finish_test_before_get_all_answers = Convert.ToInt32(dataReader.GetValue(17));
                   this.time_true_endless = Convert.ToInt32(dataReader.GetValue(18));
                   this.time_true_limited = Convert.ToInt32(dataReader.GetValue(19));
                   this.time_limit_value = dataReader.GetValue(20).ToString();
                   this.blend_no_blend = Convert.ToInt32(dataReader.GetValue(21));
                   this.blend_individual = Convert.ToInt32(dataReader.GetValue(22));
                   this.blend_all_questions = Convert.ToInt32(dataReader.GetValue(23));
                   this.descript_display_for_test_time = Convert.ToInt32(dataReader.GetValue(24));
                   this.descript_display_for_error = Convert.ToInt32(dataReader.GetValue(25));
                   this.result_display_error_after_test = Convert.ToInt32(dataReader.GetValue(26));
                   this.result_display_rigth_answer = Convert.ToInt32(dataReader.GetValue(27));
                   this.group_id = Convert.ToInt32(dataReader.GetValue(28));
                }
                dataReader.Close();
                // Заполним список вопросов теста
                SqlDataReader dataReaderQuest;
                string sql_quest = "SELECT * FROM questions WHERE test_id='" + id_test.ToString() + "';";
                SqlCommand command_quest = new SqlCommand(sql_quest, connection);
                dataReaderQuest = command_quest.ExecuteReader();

                while (dataReaderQuest.Read())
                {
                    questions_list.Add(new TestDB.Question(
                        Convert.ToInt32(dataReaderQuest.GetValue(0)), //id
                        dataReaderQuest.GetValue(1).ToString(), //name
                        dataReaderQuest.GetValue(2).ToString(), //description
                        Convert.ToInt32(dataReaderQuest.GetValue(3)), //test_id
                        Convert.ToInt32(dataReaderQuest.GetValue(4)), //img_id
                        Convert.ToInt32(dataReaderQuest.GetValue(5)), //type_id
                        Convert.ToInt32(dataReaderQuest.GetValue(6)), //points
                        dataReaderQuest.GetValue(7).ToString(), //additional
                        dataReaderQuest.GetValue(8).ToString(), //comments
                        Convert.ToInt32(dataReaderQuest.GetValue(9)) //group_id
                        ));
                }
                dataReaderQuest.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки вопросов теста: " + ex.ToString());
            }
        }

        public TestDB() { }

        public TestDB(string name) 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM tests WHERE name = '" + name.ToString() + "' ORDER BY id DESC";
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                   this.id = Convert.ToInt32(dataReader.GetValue(0));
                   this.name = dataReader.GetValue(1).ToString();
                   this.owner_id = Convert.ToInt32(dataReader.GetValue(2));
                   this.description = dataReader.GetValue(3).ToString();
                   this.date_created = Convert.ToDateTime(dataReader.GetValue(4)); 
                   this.date_last_saved = Convert.ToDateTime(dataReader.GetValue(5)); 
                   this.number_groups = Convert.ToInt32(dataReader.GetValue(6));
                   this.number_questions = Convert.ToInt32(dataReader.GetValue(7));
                   this.number_messages = Convert.ToInt32(dataReader.GetValue(8));
                   this.number_scale = Convert.ToInt32(dataReader.GetValue(9));
                   this.number_test_version = Convert.ToInt32(dataReader.GetValue(10));
                   this.number_results = Convert.ToInt32(dataReader.GetValue(11));
                   this.instructions = dataReader.GetValue(12).ToString();
                   this.display_instructions = Convert.ToInt32(dataReader.GetValue(13));
                   this.type = dataReader.GetValue(14).ToString();
                   this.navi_true_get_back_questions = Convert.ToInt32(dataReader.GetValue(15));
                   this.navi_true_skip_questions = Convert.ToInt32(dataReader.GetValue(16));
                   this.navi_block_finish_test_before_get_all_answers = Convert.ToInt32(dataReader.GetValue(17));
                   this.time_true_endless = Convert.ToInt32(dataReader.GetValue(18));
                   this.time_true_limited = Convert.ToInt32(dataReader.GetValue(19));
                   this.time_limit_value = dataReader.GetValue(20).ToString();
                   this.blend_no_blend = Convert.ToInt32(dataReader.GetValue(21));
                   this.blend_individual = Convert.ToInt32(dataReader.GetValue(22));
                   this.blend_all_questions = Convert.ToInt32(dataReader.GetValue(23));
                   this.descript_display_for_test_time = Convert.ToInt32(dataReader.GetValue(24));
                   this.descript_display_for_error = Convert.ToInt32(dataReader.GetValue(25));
                   this.result_display_error_after_test = Convert.ToInt32(dataReader.GetValue(26));
                   this.result_display_rigth_answer = Convert.ToInt32(dataReader.GetValue(27));
                   this.group_id = Convert.ToInt32(dataReader.GetValue(28));
                }
                connection.Close();

                // Создаём вопрос по дефолту и добавляем его в list всех вопросов
                Question first_question = new Question();
                first_question.name = "Вопрос 1";
                first_question.test_id = this.id;
                first_question.AddToDB();
                first_question = null;
                //Получим новый вопрос с присвоенным Id
                TestDB.Question current_question = new TestDB.Question();
                current_question.GetLastByTestId(this.id);

                // Добавим в список
                this.questions_list.Add(current_question);

            }
            catch (Exception ex)
            {

            }       
        }

        public void AddToDB() 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                
                string sql = "INSERT INTO tests(" +
                    "name," +
                    " owner_id," +
                    " description," +
                    " date_created," +
                    " date_last_saved," +
                    " number_groups," +
                    " number_questions," +
                    " number_messages," +
                    " number_scale," +
                    " number_test_version," +
                    " number_results," +
                    " instructions," +
                    " display_instructions," +
                    " type," +
                    " navi_true_get_back_questions," +
                    " navi_true_skip_questions," +
                    " navi_block_finish_test_before_get_all_answers," +
                    " time_true_endless," +
                    " time_true_limited," +
                    " time_limit_value," +
                    " blend_no_blend," +
                    " blend_individual," +
                    " blend_all_questions," +
                    " descript_display_for_test_time," +
                    " descript_display_for_error," +
                    " result_display_error_after_test," +
                    " result_display_rigth_answer," +
                    " group_id" +
                    " ) VALUES('"
                    + this.name + "', '"
                    + this.owner_id + "', '"
                    + this.description + "', '"
                    + this.date_created + "', '"
                    + this.date_last_saved + "', '"
                    + this.number_groups + "', '"
                    + this.number_questions + "', '"
                    + this.number_messages + "', '"
                    + this.number_scale + "', '"
                    + this.number_test_version + "', '"
                    + this.number_results + "', '"
                    + this.instructions + "', '"
                    + this.display_instructions + "', '"
                    + this.type + "', '"
                    + this.navi_true_get_back_questions + "', '"
                    + this.navi_true_skip_questions + "', '"
                    + this.navi_block_finish_test_before_get_all_answers + "', '"
                    + this.time_true_endless + "', '"
                    + this.time_true_limited + "', '"
                    + this.time_limit_value + "', '"
                    + this.blend_no_blend + "', '"
                    + this.blend_individual + "', '"
                    + this.blend_all_questions + "', '"
                    + this.descript_display_for_test_time + "', '"
                    + this.descript_display_for_error + "', '"
                    + this.result_display_error_after_test + "', '"
                    + this.result_display_rigth_answer + "', '"
                    + this.group_id 
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


        public string group_name()
        {
            string result = "";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM tests_group WHERE id = " + this.group_id.ToString();
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

        public string user_name()
        {
            string user_name = "";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT name FROM admins WHERE id = " + this.owner_id.ToString();
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

        public void MoveToGroupId(int to_group_id) 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string sql = "UPDATE tests SET group_id = '" + to_group_id.ToString() + "' WHERE id = '" + this.id.ToString()  + "';";
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
                // Получим тест
                TestDB test = new TestDB(id);
                // Получим все id вопросов, которые будем удалять
                for (int i = 0; i < test.questions_list.Count(); i++)
                {
                    // Удалим ответы к вопросам теста из таблицы answers зная id вопросов чтобы
                    // не было конфлика FK
                    string sql_answers_test = "DELETE FROM answers WHERE questions_id = '" + test.questions_list[i].id.ToString() + "';";
                    SqlCommand command_answers = new SqlCommand(sql_answers_test, connection);
                    connection.Open();
                    command_answers.ExecuteNonQuery();
                    connection.Close();
                }

                // Удалим вопросы теста из таблицы questions
                // не было конфлика FK
                string sql_quest_tests = "DELETE FROM questions WHERE test_id = '" + id.ToString() + "';";
                SqlCommand command_quest_tests = new SqlCommand(sql_quest_tests, connection);
                connection.Open();
                command_quest_tests.ExecuteNonQuery();
                connection.Close();

                // Далее удалим тест
                string sql_test = "DELETE FROM tests WHERE id = '" + id.ToString() + "';";
                SqlCommand command_test = new SqlCommand(sql_test, connection);
                connection.Open();
                command_test.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // ДОП КЛАССЫ ------------------------------------------------------------

        public class Question
        {

            public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

            public int id;
            public string name;
            public string description;
            public int test_id;
            public int img_id;
            public int type_id;
            public int points;
            public string additional;
            public string comments;
            public int group_id;

            
            List<Answers> answers_list;



            public Question() { }

            public Question(string name) 
            {
                this.name = name;
            }

            public Question(int id, string name, string description, int test_id, int img_id, int type_id,
                            int points, string additional, string comments, int group_id) 
            {
                this.id = id;
                this.name = name;
                this.description = description;
                this.test_id = test_id;
                this.img_id = img_id;
                this.type_id = type_id;
                this.points = points;
                this.additional = additional;
                this.comments = comments;
                this.group_id = group_id;
 
            }

            public Question(int test_id) 
            {
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    SqlDataReader dataReader;
                    string sql = "SELECT * FROM questions WHERE test_id = '" + test_id.ToString() + "' ORDER BY id DESC";
                    SqlCommand command = new SqlCommand(sql, connection);
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                       this.id = Convert.ToInt32(dataReader.GetValue(0));
                       this.name = dataReader.GetValue(1).ToString();
                       this.description = dataReader.GetValue(2).ToString();
                       this.test_id = Convert.ToInt32(dataReader.GetValue(3));
                       this.img_id = Convert.ToInt32(dataReader.GetValue(4));
                       this.type_id = Convert.ToInt32(dataReader.GetValue(5));
                       this.points = Convert.ToInt32(dataReader.GetValue(6));
                       this.additional = dataReader.GetValue(7).ToString(); 
                       this.comments = dataReader.GetValue(8).ToString();
                       this.group_id = Convert.ToInt32(dataReader.GetValue(9));
                    }
                    connection.Close();

                    // Создаём ответ по дефолту и добавляем его в list всех вопросов
                    Answers first_answer = new Answers();
                    first_answer.name = "Ответ #1";
                    first_answer.questions_id = this.id;
                    first_answer.AddToDB();
                    // Добавим в список
                    this.answers_list.Add(first_answer);

                }
                catch (Exception ex) { }             
                }

            public void AddToDB()
            {
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {

                    string sql = "INSERT INTO questions(" +
                        "name," +
                        "description, " +
                        "test_id, " +
                        "img_id," +
                        "type_id, " +
                        "points, " +
                        "additional, " +
                        "comments, " +
                        "group_id " +
                        ") VALUES('"
                        + this.name + "', '"
                        + this.description + "', '"
                        + this.test_id + "', '"
                        + this.img_id + "', '"
                        + this.type_id + "', '"
                        + this.points + "', '"
                        + this.additional + "', '"
                        + this.comments + "', '"
                        + this.group_id
                        + "');";

                    SqlCommand command = new SqlCommand(sql, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка создания Вопроса теста: " +  ex.ToString());
                }
            }

            public void GetLastByTestId(int test_id)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    SqlDataReader dataReader;
                    string sql = "SELECT TOP 1 FROM questions WHERE test_id = '" + test_id.ToString() + "' ORDER BY id DESC";
                    SqlCommand command = new SqlCommand(sql, connection);
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                       this.id = Convert.ToInt32(dataReader.GetValue(0));
                       this.name = dataReader.GetValue(1).ToString();
                       this.description = dataReader.GetValue(2).ToString();
                       this.test_id = Convert.ToInt32(dataReader.GetValue(3));
                       this.img_id = Convert.ToInt32(dataReader.GetValue(4));
                       this.type_id = Convert.ToInt32(dataReader.GetValue(5));
                       this.points = Convert.ToInt32(dataReader.GetValue(6));
                       this.additional = dataReader.GetValue(7).ToString(); 
                       this.comments = dataReader.GetValue(8).ToString();
                       this.group_id = Convert.ToInt32(dataReader.GetValue(9));
                    }
                    connection.Close();

                    //// Создаём ответ по дефолту и добавляем его в list всех вопросов
                    //Answers first_answer = new Answers();
                    //first_answer.name = "Ответ #1";
                    //first_answer.questions_id = this.id;
                    //first_answer.AddToDB();
                    //// Добавим в список
                    //this.answers_list.Add(first_answer);

                }
                catch (Exception ex) { }             
            }

            public void Delete(int id) 
            {
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    string sql = "DELETE FROM questions WHERE id = '" + id.ToString() +  "';";
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

        public class Answers 
        {
            public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            
            public int id;
            public string name;
            public float points;
            public int position;
            public string comment;
            public int questions_id;
            
            public Answers() { }
            public Answers(int question_id)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    SqlDataReader dataReader;
                    string sql = "SELECT * FROM answers WHERE questions_id = '" + question_id.ToString() + "' ORDER BY id DESC";
                    SqlCommand command = new SqlCommand(sql, connection);
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                       this.id = Convert.ToInt32(dataReader.GetValue(0));
                       this.name = dataReader.GetValue(1).ToString();
                       this.points = Convert.ToInt32(dataReader.GetValue(2));
                       this.position = Convert.ToInt32(dataReader.GetValue(3));
                       this.comment = dataReader.GetValue(4).ToString();
                       this.questions_id = Convert.ToInt32(dataReader.GetValue(5));

                    }
                    connection.Close();

                    // Создаём ответ по дефолту и добавляем его в list всех вопросов
                    //Answers first_answer = new Answers(this.id);
                    //first_answer.name = "Ответ #1";
                    //first_answer.AddToDB();
                    //// Добавим в список
                    //this.answers_list.Add(first_answer);

                }
                catch (Exception ex) { }             
                }           
 
            public void AddToDB()
            {
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {

                    string sql = "INSERT INTO answers(" +
                        "name, " +
                        "points, " +
                        "position, " +
                        "comment, " +
                        "questions_id " +
                        ") VALUES('"
                        + this.name + "', '"
                        + this.points + "', '"
                        + this.position + "', '"
                        + this.comment + "', '"
                        + this.questions_id
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

        }

        public class question_group 
        {
            int id;
            string name;
            string description;
            DateTime date_created;
            int as_list;
            string as_display;
            int quantity_display_elements;
            int test_id;

            List<Answers> answers_list;

        }


    }
}
