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


    public partial class AddUser : Form
    {
        

        int user_group_id;

        public AddUser()
        {
            InitializeComponent();
            tbRegDate.Text = DateTime.Now.ToString("");
            UsersGroupDB obj = new UsersGroupDB();
            obj.Fill();      

            Dictionary<string, string> user_group_list = new Dictionary<string, string>();
            for (int i = 0; i < obj.list_objects.Count; i++)
            {
                user_group_list.Add(obj.list_objects[i].id.ToString(), obj.list_objects[i].name);
            }

            cbGroup.DataSource = new BindingSource(user_group_list, null);           
            cbGroup.DisplayMember = "Value";
            cbGroup.ValueMember = "Key";
            cbGroup.SelectedIndex = 0;
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

            UserDB ug = new UserDB();
            ug.name = tbName.Text;
            ug.last_name = tbSername.Text;
            ug.middle_name = tbMiddleName.Text;
            ug.login = tbLogin.Text;
            ug.password = tbPassword.Text;
            ug.register_time = tbRegDate.Text;
            ug.register_method_id = 0; //возможно потом добавим 
            ug.block = 0;
            ug.organization_id = 1; // default
            ug.comment = tbComment.Text;
            ug.phone = ""; //возможно потом добавим
            ug.email = ""; //возможно потом добавим
            ug.address = ""; //возможно потом добавим
            ug.confirmed = 1;
            ug.photo_url = "";
            ug.group_id = Convert.ToInt32(((KeyValuePair<string, string>)cbGroup.SelectedItem).Key);
            ug.type_user = 3; // 3-пользователь
            ug.AddToDB();
            // Обновим datagrid
            // Обновим dgv
            MainForm main_fm = (MainForm)Application.OpenForms["MainForm"];
            main_fm.UpdateDGV_Users();

            this.Close();
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
