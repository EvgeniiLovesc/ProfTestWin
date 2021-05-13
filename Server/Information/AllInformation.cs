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
    public partial class AllInformation : Form
    {


        public AllInformation()
        {
            InitializeComponent();
            cbSetDate.Items.Add("3 дня");
            cbSetDate.Items.Add("10 дней");
            cbSetDate.Items.Add("30 дней");
            cbSetDate.Items.Add("3 месяца");
            cbSetDate.Items.Add("6 месяцев");
            cbSetDate.Items.Add("1 год");
            cbSetDate.Items.Add("за всё время");

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
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            AddInformation ai = new AddInformation();
            ai.Show();
        }

        private void cbTests_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UserTypes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
