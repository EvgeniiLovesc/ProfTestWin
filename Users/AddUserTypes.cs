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
    public partial class AddUserTypes : Form
    {


        public AddUserTypes()
        {
            InitializeComponent();
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
            TypeUserDB obj = new TypeUserDB();
            obj.AddToDB(tbNameTypeUser.Text);
            UserTypes ut = new UserTypes(1);
            ut.Show();
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
            UserTypes ut = new UserTypes(1);
            ut.Show();
        }

        private void cbTests_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UserTypes_Load(object sender, EventArgs e)
        {
            
        }
    }
}
