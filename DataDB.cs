using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using NK_TEST.Results;
using NK_TEST.admins;
using NK_TEST.Users;
using NK_TEST.Rules;
using NK_TEST.Tests;

namespace NK_TEST
{
    class DataDB
    {
        public DataGridView dgvTests;
        public DataGridView dgvUsers;
        public DataGridView dgvRules;
        public DataGridView dgvServer;
        public DataGridView dgvResults;
        public DataGridView dgvAdmins;

        public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public SqlConnection connection;

        public ToolStripStatusLabel statusConnection;
        public bool status;
        public Label serverStatus;
        public PictureBox pbStatus;

        Image img_folder = Properties.Resources.folder as Bitmap;
        Image img_test = Properties.Resources.test as Bitmap;
        Image img_select;
        Image img_no = Properties.Resources.no_img as Bitmap;
        Image img_user = Properties.Resources.man_icon as Bitmap;
        Image img_rules = Properties.Resources.Rules_of_Fight_Club_icon as Bitmap;


        public string user_group_name;
        public string rules_group_name;
        public string test_group_name;
        public string question_group_name;

        public void FillTests() 
        {
            
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                statusConnection.Text = "Подключено";
                this.serverStatus.Text = "Подключено";
                this.status = true;
                pbStatus.Visible = true;
                statusConnection.BackColor = Color.Aqua;
                // Заполняем dgv 
                FillDGVTest();
                FillDGVUsers();
                FillDGVRules ();
                FillDGVAdmins();
                FillDGVResults();

                connection.Close();
            }
            catch (Exception ex)
            {
                statusConnection.Text = "Ошибка соединения";
                serverStatus.Text = "Ошибка соединения";
                this.status = false;
                pbStatus.Visible = false;
                statusConnection.BackColor = Color.Coral;
                MessageBox.Show(ex.Message);
            }

        }

        public void FillDGVTest() 
        {   
            dgvTests.Rows.Clear(); 
            if (1 == 1) 
            {
                TestsDB tests = new TestsDB();
                tests.Fill();
                for (int i = 0; i < tests.objects.Count; i++)
                {
                   if (tests.objects[i].group_name() == "") { img_select = img_no; } else { img_select = img_folder; }

                    string group = tests.objects[i].group_name();

                    dgvTests.Rows.Add(
                        tests.objects[i].id,
                        img_select,
                        group,
                        img_test,
                        tests.objects[i].name,
                        tests.objects[i].user_name(),
                        tests.objects[i].date_last_saved.ToString()
                    );
                }           
            }
        }

        public void FillDGVUsers() 
        {
            dgvUsers.Rows.Clear();            
            if (1 == 1)
            {
                UsersDB users = new UsersDB();
                users.Fill();
                for (int i = 0; i < users.objects.Count; i++)
                {
                   if (users.objects[i].group_name() == "") { img_select = img_no; } else { img_select = img_folder; }
                    
                    dgvUsers.Rows.Add(
                        users.objects[i].id,
                        img_select,
                        users.objects[i].group_name(),
                        img_user,
                        users.objects[i].last_name,
                        users.objects[i].name,
                        users.objects[i].middle_name,
                        users.objects[i].login,
                        users.objects[i].comment
                    );
                    }
            }

        }

        public void FillDGVRules() 
        {
            dgvRules.Rows.Clear();  
            if (1 == 1) 
            {
                RulesDB rules = new RulesDB();
                rules.Fill();
                for (int i = 0; i < rules.objects.Count; i++)
                {
                   if (rules.objects[i].group_name() == "") { img_select = img_no; } else { img_select = img_folder; }

                    string group = rules.objects[i].group_name();

                    dgvRules.Rows.Add(
                        rules.objects[i].id,
                        img_select,
                        group,
                        img_user,
                        rules.objects[i].name,
                        rules.objects[i].test_count(),
                        rules.objects[i].users_count(),
                        rules.objects[i].raspisanie_type(),
                        rules.objects[i].number_attempt_str()
                    );
                }           
            }

        }

        public void FillDGVAdmins() 
        {

            dgvAdmins.Rows.Clear();
            if (1 == 1)
            {
                AdminsDB admins = new AdminsDB();
                admins.Fill();
                for (int i = 0; i < admins.objects.Count; i++)
                {
                    dgvAdmins.Rows.Add(
                        admins.objects[i].id,
                        admins.objects[i].login,
                        admins.objects[i].password,
                        admins.objects[i].last_name,
                        admins.objects[i].name,
                        admins.objects[i].middle_name,
                        admins.objects[i].get_type_user(),
                        admins.objects[i].comment,
                        admins.objects[i].register_time
                    );
                }
            }
        }

        public void FillDGVResults() 
        {            
            if (1 == 1)
            {
                ResultsDB results = new ResultsDB();
                results.Fill();
                for (int i = 0; i < results.objects.Count; i++)
                {
                    dgvResults.Rows.Add(
                        i+1,
                        results.objects[i].user_sername(),
                        results.objects[i].user_name(),
                        results.objects[i].user_middlename(),
                        results.objects[i].user_groupname(),
                        results.objects[i].test_name(),
                        results.objects[i].date,
                        results.objects[i].time,
                        results.objects[i].status,
                        results.objects[i].value,
                        results.objects[i].result
                    );
                }
            }

        }

    }


}
