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
    public partial class AddAdmin : Form
    {

        public AddAdmin()
        {
            InitializeComponent();
            tbRegDate.Text = DateTime.Now.ToString("");
            TypeUserDB obj = new TypeUserDB();
            obj.Fill();            

            Dictionary<string, string> user_types = new Dictionary<string, string>();
            for (int i = 0; i < obj.list_objects.Count; i++)
            {
                user_types.Add(obj.list_objects[i].id.ToString(), obj.list_objects[i].name);
            }

            cbGroup.DataSource = new BindingSource(user_types, null);           
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

            AdminDB obj = new AdminDB(
                tbName.Text,
                tbSername.Text,
                tbMiddleName.Text,
                tbLogin.Text,
                tbPassword.Text,
                tbRegDate.Text = DateTime.Now.ToString(""),
                tbComment.Text,
                Convert.ToInt32(((KeyValuePair<string,string>)cbGroup.SelectedItem).Key)
                );
            // Запишем в базу
            obj.AddToDB();
            // Обновим dgv
            MainForm main_fm = (MainForm)Application.OpenForms["MainForm"];
            main_fm.UpdateDGV_Users();
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
