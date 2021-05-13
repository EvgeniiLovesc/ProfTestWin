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
    public partial class EditUserGroup : Form
    {


        public EditUserGroup()
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
    }
}
