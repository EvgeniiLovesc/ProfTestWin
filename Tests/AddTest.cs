using NK_TEST.admins;
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
    public partial class AddTest : Form
    {

        public AddTest()
        {
            InitializeComponent();
            //int selected_index = 0;

            TestsGroupDB tu_obj = new TestsGroupDB();
            tu_obj.Fill();            

            Dictionary<string, string> test_groups = new Dictionary<string, string>();
            for (int i = 0; i < tu_obj.list_objects.Count; i++)
            {
                test_groups.Add(tu_obj.list_objects[i].id.ToString(), tu_obj.list_objects[i].name);
                // Определим selected_index для выбранного типа
                //if (obj.type_user == tu_obj.list_objects[i].id) { selected_index = i; }
            }

            cbGroup.DataSource = new BindingSource(test_groups, null);           
            cbGroup.DisplayMember = "Value";
            cbGroup.ValueMember = "Key";
            cbGroup.SelectedIndex = 0;
            //cbGroup.SelectedIndex = selected_index;



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
            // Создаём тест
            TestDB test = new TestDB();
            test.name = tbName.Text;
            test.group_id = Convert.ToInt32(((KeyValuePair<string,string>)cbGroup.SelectedItem).Key);
            MainForm main_fm = (MainForm)Application.OpenForms["MainForm"];
            AdminDB user = new AdminDB(main_fm.login);
            test.owner_id = user.id;
            test.date_created = DateTime.Now;
            test.date_last_saved = DateTime.Now;

            test.AddToDB();

            
            this.Close();
            EditTest et = new EditTest(test.name);
            test = null;
            et.Show();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
