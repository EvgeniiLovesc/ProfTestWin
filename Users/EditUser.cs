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
    public partial class EditUser : Form
    {
        private int id_user;

        public EditUser(int _id_user)
        {
            InitializeComponent();
            this.id_user = _id_user;
            UserDB obj = new UserDB(_id_user);
            tbName.Text = obj.name;
            tbSername.Text = obj.last_name;
            tbMiddleName.Text = obj.middle_name;
            tbLogin.Text = obj.login;
            tbPassword.Text = obj.password;
            tbRegDate.Text = obj.register_time;
            tbComment.Text = obj.comment;
            tbPhone.Text = obj.phone;
            tbEmail.Text = obj.email;
            tbAddress.Text = obj.address;
            cbConfirmed.Checked = Convert.ToBoolean(obj.confirmed);
            cbBlock.Checked = Convert.ToBoolean(obj.block);

            int selected_index = 0;

            UsersGroupDB tu_obj = new UsersGroupDB();
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
            
            UserDB obj = new UserDB(this.id_user);
            obj.name = tbName.Text;
            obj.last_name = tbSername.Text;
            obj.middle_name = tbMiddleName.Text;
            obj.login = tbLogin.Text;                    
            obj.password = tbPassword.Text;
            //obj.register_time = 
            obj.block = Convert.ToInt32(cbBlock.Checked);
            //obj.organization_id = 
            obj.comment = tbComment.Text;
            obj.phone = tbPhone.Text;
            obj.email = tbEmail.Text;
            obj.address = tbAddress.Text;
            obj.confirmed = Convert.ToInt32(cbConfirmed.Checked);
            //obj.photo_url = 
            obj.group_id = Convert.ToInt32(((KeyValuePair<string,string>)cbGroup.SelectedItem).Key);
            //obj.type_user = 
            
            obj.Save();
            // Обновим dgv
            MainForm main_fm = (MainForm)Application.OpenForms["MainForm"];
            main_fm.UpdateDGV_Users();
            this.Close();
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
