using NK_TEST.admins;
using NK_TEST.Rules;
using NK_TEST.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NK_TEST.Users
{
    public partial class AddRules : Form
    {


        Image img_folder = Properties.Resources.folder as Bitmap;
        Image img_test = Properties.Resources.test as Bitmap;
        Image img_no = Properties.Resources.no_img as Bitmap;
        Image img_user = Properties.Resources.man_icon as Bitmap;
        Image img_rules = Properties.Resources.Rules_of_Fight_Club_icon as Bitmap;
        TestsDB tests = new TestsDB();
        UsersDB users = new UsersDB();
        bool first_load_tests = true;
        bool first_load_users = true;

        public AddRules()
        {
            InitializeComponent();

            // ТЕСТЫ ------------------------------------------------------------------------------
            dgvTests.Rows.Clear();
            TestsGroupDB obj = new TestsGroupDB();
            obj.Fill();      

            Dictionary<string, string> test_group_list = new Dictionary<string, string>();
            for (int i = 0; i < obj.list_objects.Count; i++)
            {
                test_group_list.Add(obj.list_objects[i].id.ToString(), obj.list_objects[i].name);
            }

            cbTests.DataSource = new BindingSource(test_group_list, null);           
            cbTests.DisplayMember = "Value";
            cbTests.ValueMember = "Key";
            cbTests.SelectedIndex = 0;

            tests = new TestsDB();
            tests.Fill(Convert.ToInt32(((KeyValuePair<string, string>)cbTests.SelectedItem).Key));
            for (int i = 0; i < tests.objects.Count; i++)
            {
                dgvTests.Rows.Add(
                    tests.objects[i].id,
                    false,
                    img_test,
                    tests.objects[i].name
                );
            }
            // ПОЛЬЗОВАТЕЛИ -------------------------------------------------------------------------
            dgvUsers.Rows.Clear();
            UsersGroupDB obj_user = new UsersGroupDB();
            obj_user.Fill();      

            Dictionary<string, string> user_group_list = new Dictionary<string, string>();
            for (int i = 0; i < obj_user.list_objects.Count; i++)
            {
                user_group_list.Add(obj_user.list_objects[i].id.ToString(), obj_user.list_objects[i].name);
            }

            cbUsers.DataSource = new BindingSource(user_group_list, null);           
            cbUsers.DisplayMember = "Value";
            cbUsers.ValueMember = "Key";
            cbUsers.SelectedIndex = 0;

            users = new UsersDB();
            users.Fill(Convert.ToInt32(((KeyValuePair<string, string>)cbUsers.SelectedItem).Key));
            for (int i = 0; i < users.objects.Count; i++)
            {
                dgvUsers.Rows.Add(
                    users.objects[i].id,
                    false,
                    img_test,
                    users.objects[i].last_name
                );
            }
            // ГРУППА ПРАВИЛ -------------------------------------------------------------------------
            RulesGroupDB obj_rules = new RulesGroupDB();
            obj_rules.Fill();      

            Dictionary<string, string> rules_group_list = new Dictionary<string, string>();
            for (int i = 0; i < obj_rules.list_objects.Count; i++)
            {
                rules_group_list.Add(obj_rules.list_objects[i].id.ToString(), obj_rules.list_objects[i].name);
            }

            cbRulesGroup.DataSource = new BindingSource(rules_group_list, null);           
            cbRulesGroup.DisplayMember = "Value";
            cbRulesGroup.ValueMember = "Key";
            cbRulesGroup.SelectedIndex = 0;
            // РАСПИСАНИЕ ----------------------------------------------------------------------------
            rbRaspType2.Checked = true;
            rasp1_dateStart.CustomFormat = "dd.MM.yyyy hh:mm:ss"; 
            rasp1_dateFinish.CustomFormat = "dd.MM.yyyy hh:mm:ss"; 
            // КОЛИЧЕСТВО ПОПЫТОК --------------------------------------------------------------------

            //cbNumberAttemptValue.SelectedIndex = 0;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {

            // Тип расписания(id)
            int raspisanie_type_id = 1;
            DateTime dateStart;
            DateTime dateFinish;
            if (rbRaspType1.Checked) 
            { 
                raspisanie_type_id = 1;
                dateStart = rasp1_dateStart.Value;
                dateFinish = rasp1_dateFinish.Value;
            }
            else if (rbRaspType2.Checked)
            {
                raspisanie_type_id = 2;
                dateStart = rasp2_dateStart.Value;
                dateFinish = rasp2_dateFinish.Value;
            }
            else { 
                raspisanie_type_id = 3;
                dateStart = rasp3_dateStart.Value;
                dateFinish = rasp3_dateFinish.Value;
            }

            // Id авторизованного админа
            MainForm main_fm = (MainForm)Application.OpenForms["MainForm"];
            string name_admin = main_fm.getAdminName();
            AdminDB admin = new AdminDB(name_admin);

            // Получаем id выбранной группы тестов
            int test_group_id_selected = Convert.ToInt32(((KeyValuePair<string, string>)cbTests.SelectedItem).Key);

            // Количество попыток
            int _number_attempt = 10000000;
            if (cbNumberAttempt.Checked) {
                _number_attempt = Convert.ToInt32(cbNumberAttemptValue.Text); 
            }

            RuleDB rule = new RuleDB(
                tb_Name.Text,
                tbDescription.Text,
                raspisanie_type_id,
                dateStart,
                dateFinish,
                _number_attempt,
                admin.id,
                Convert.ToInt32(((KeyValuePair<string, string>)cbRulesGroup.SelectedItem).Key)
                );

            // Применить ли правило ко всей группе тестов?
            if (cbTestsAllinGroup.Checked)
            {
                rule.AddToDB(true, test_group_id_selected);
            }
            else 
            {
                // Получим ID лист выбранных тестов
                List<int> list_tests_id = new List<int>(); 
                foreach(DataGridViewRow r in dgvTests.Rows)
                {
                    if (Convert.ToBoolean(r.Cells[1].Value))
                    {
                        list_tests_id.Add(Convert.ToInt32(r.Cells[0].Value));
                    }                     
                }
                // Если выбраны какие-нибудь тесты, добавляем их
                if (list_tests_id.Count > 0) {rule.AddToDB(true, list_tests_id); }
            }

            // Получаем id выбранной группы юзеров            
            int user_group_id_selected = Convert.ToInt32(((KeyValuePair<string, string>)cbUsers.SelectedItem).Key);
            // Применить ли правило ко всей группе юзеров?
            if (cbUsersAllInGroup.Checked)
            {
                rule.AddToDB(false, user_group_id_selected);
            }
            else 
            {
                // Получим ID лист выбранных пользователей
                List<int> list_users_id = new List<int>();
                foreach(DataGridViewRow r in dgvUsers.Rows)
                {
                    if (Convert.ToBoolean(r.Cells[1].Value))
                    {
                        list_users_id.Add(Convert.ToInt32(r.Cells[0].Value));
                    }                     
                }
                // Если выбраны какие-нибудь юзеры, добавляем их
                if (list_users_id.Count > 0) {rule.AddToDB(false, list_users_id); }
            }
            main_fm.UpdateDGV_Rules();
            this.Close();

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cbTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обновим dgvTests
            dgvTests.Rows.Clear();
            if (first_load_tests == false) 
            {
                tests.Fill(Convert.ToInt32(((KeyValuePair<string, string>)cbTests.SelectedItem).Key));

                for (int i = 0; i < tests.objects.Count; i++)
                {
                    dgvTests.Rows.Add(
                        tests.objects[i].id,
                        false,
                        img_test,
                        tests.objects[i].name
                    );
                }
            }
            first_load_tests = false;
        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обновим dgvUsers
            dgvUsers.Rows.Clear();
            if (first_load_users == false)
            { 
                users.Fill(Convert.ToInt32(((KeyValuePair<string, string>)cbUsers.SelectedItem).Key));
                for (int i = 0; i < users.objects.Count; i++)
                {
                    dgvUsers.Rows.Add(
                        users.objects[i].id,
                        false,
                        img_test,
                        users.objects[i].last_name
                    );
                }
            }
            first_load_users = false;
        }

        private void cbNumberAttemptValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rasp1_dateStart_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
