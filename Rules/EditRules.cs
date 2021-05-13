using NK_TEST.admins;
using NK_TEST.Rules;
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
    public partial class EditRules : Form
    {
        Image img_folder = Properties.Resources.folder as Bitmap;
        Image img_test = Properties.Resources.test as Bitmap;
        Image img_no = Properties.Resources.no_img as Bitmap;
        Image img_user = Properties.Resources.man_icon as Bitmap;
        Image img_rules = Properties.Resources.Rules_of_Fight_Club_icon as Bitmap;

        RuleDB editable_rule;

        public EditRules(int id_rules)
        {
            InitializeComponent();
            RuleDB obj = new RuleDB(id_rules);
            // Имя
            tb_Name.Text = obj.name;

            // Группа
            RulesGroupDB group = new RulesGroupDB();
            group.Fill(); 
            int selected_index = 0;

            Dictionary<string, string> rules_group_list = new Dictionary<string, string>();
            for (int i = 0; i < group.list_objects.Count; i++)
            {
                rules_group_list.Add(group.list_objects[i].id.ToString(), group.list_objects[i].name);
                // Определим selected_index для выбранного типа
                if (obj.group_id == group.list_objects[i].id) { selected_index = i; }
            }

            cbRulesGroup.DataSource = new BindingSource(rules_group_list, null);           
            cbRulesGroup.DisplayMember = "Value";
            cbRulesGroup.ValueMember = "Key";
            // SelectedIndex
            cbRulesGroup.SelectedIndex = selected_index;

            //Заполним dgvTests
            RuleDB.rl_tests test_list = new RuleDB.rl_tests();
            test_list.FillByRulesID(obj.id);
            for (int i = 0; i < test_list.objects.Count; i++)
            {
                dgvTests.Rows.Add(
                    test_list.objects[i].test_name
                );
            }

            //Заполним dgvUsers
            RuleDB.rl_users users_list = new RuleDB.rl_users();
            users_list.FillByRulesID(obj.id);
            for (int i = 0; i < users_list.objects.Count; i++)
            {
                dgvUsers.Rows.Add(
                    users_list.objects[i].user_name
                );
            }



            // Тип расписания
            if (obj.raspisanie_type_id == 1) 
            {
                rbRaspType1.Checked = true;
                rasp1_dateStart.Value = obj.time_start;
                rasp1_dateFinish.Value = obj.time_finish;
            }
            if (obj.raspisanie_type_id == 2) 
            { 
                rbRaspType2.Checked = true;
                rasp2_dateStart.Value = obj.time_start;
                rasp2_dateFinish.Value = obj.time_finish;
                
            }
            if (obj.raspisanie_type_id == 3) 
            { 
                rbRaspType3.Checked = true;
                rasp3_dateStart.Value = obj.time_start;
                rasp3_dateFinish.Value = obj.time_finish;                
            }

            // Количество попыток
            if (obj.number_attempt == 10000000)
            { 
                cbNumberAttempt.Checked = false; 
            }
            else 
            { 
                cbNumberAttempt.Checked = true;
                cbNumberAttemptValue.Text = obj.number_attempt.ToString();
            }

            // Комментарии
            tbDescription.Text = obj.description;

            editable_rule = obj;

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
            int test_group_id_selected = Convert.ToInt32(((KeyValuePair<string, string>)cbRulesGroup.SelectedItem).Key);

            // Количество попыток
            int _number_attempt = 10000000;
            if (cbNumberAttempt.Checked) {
                _number_attempt = Convert.ToInt32(cbNumberAttemptValue.Text); 
            }
            //Находим правило 
            editable_rule.name = tb_Name.Text;
            editable_rule.description = tbDescription.Text;
            editable_rule.raspisanie_type_id = raspisanie_type_id;
            editable_rule.time_start = dateStart;
            editable_rule.time_finish = dateFinish;
            editable_rule.number_attempt = _number_attempt;
            editable_rule.admin_id = admin.id;
            editable_rule.group_id = Convert.ToInt32(((KeyValuePair<string, string>)cbRulesGroup.SelectedItem).Key);
            editable_rule.Save();
            
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

        private void dgvTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
