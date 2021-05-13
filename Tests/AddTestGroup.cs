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
    public partial class AddTestGroup : Form
    {


        public AddTestGroup()
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
            TestsGroupDB tg = new TestsGroupDB();
            tg.name = tbName.Text;
            tg.description = tbDescription.Text;
            tg.comment = tbComment.Text;
            tg.date_created = tbRegDate.Text;
            MainForm main_fm = (MainForm)Application.OpenForms["MainForm"];
            AdminDB obj = new AdminDB(main_fm.getAdminName());
            tg.owner_id = obj.id;
            tg.AddToDB();
            
            this.Close();
            MessageBox.Show("Группа " + group_name + " создана!");            
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
