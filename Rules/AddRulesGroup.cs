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
    public partial class AddRulesGroup : Form
    {


        public AddRulesGroup()
        {
            InitializeComponent();
            tbRegDate.Text = DateTime.Now.ToString("");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUserGroup_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            string group_name = "";
            group_name = tbName.Text;
            RulesGroupDB ug = new RulesGroupDB();
            ug.name = tbName.Text;
            ug.description = tbDescription.Text;
            ug.comment = tbComment.Text;
            ug.date_created = tbRegDate.Text;
            MainForm main_fm = (MainForm)Application.OpenForms["MainForm"];
            UserDB obj = new UserDB(main_fm.login);
            ug.owner_id = obj.id;
            ug.AddToDB();
            // Обновим dgv
            main_fm.UpdateDGV_Rules();            
            
            this.Close();
            MessageBox.Show("Группа " + group_name + " создана!");
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
