using NK_TEST.admins;
using NK_TEST.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NK_TEST.Admins
{
    public partial class EditAdmin : Form
    {

        private int id_admin;

        public EditAdmin(int _id_admin)
        {
            InitializeComponent();
            this.id_admin = _id_admin;
            AdminDB obj = new AdminDB(_id_admin);
            tbName.Text = obj.name;
            tbSername.Text = obj.last_name;
            tbMiddleName.Text = obj.middle_name;
            tbLogin.Text = obj.login;
            tbPassword.Text = obj.password;
            tbRegDate.Text = obj.register_time;
            tbComment.Text = obj.comment;
            int selected_index = 0;

            TypeUserDB tu_obj = new TypeUserDB();
            tu_obj.Fill();            

            Dictionary<string, string> user_types = new Dictionary<string, string>();
            for (int i = 0; i < tu_obj.list_objects.Count; i++)
            {
                user_types.Add(tu_obj.list_objects[i].id.ToString(), tu_obj.list_objects[i].name);
                // Определим selected_index для выбранного типа
                if (obj.type_user == tu_obj.list_objects[i].id) { selected_index = i; }
            }

            cbGroup.DataSource = new BindingSource(user_types, null);           
            cbGroup.DisplayMember = "Value";
            cbGroup.ValueMember = "Key";
            cbGroup.SelectedIndex = selected_index;
            obj = null;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            AdminDB obj = new AdminDB(this.id_admin);
            obj.name = tbName.Text;
            obj.last_name = tbSername.Text;
            obj.middle_name = tbMiddleName.Text;
            //obj.register_time = tbRegDate.Text;
            obj.comment = tbComment.Text;
            obj.type_user = Convert.ToInt32(((KeyValuePair<string,string>)cbGroup.SelectedItem).Key);
            obj.login = tbLogin.Text;                    
            obj.password = tbPassword.Text;
            
            obj.Save();
            // Обновим dgv
            MainForm main_fm = (MainForm)Application.OpenForms["MainForm"];
            main_fm.UpdateDGV_Admins();
            this.Close();
        }
    }
}
