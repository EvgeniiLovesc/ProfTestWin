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
    public partial class SaveToFile : Form
    {


        Image img_folder = Properties.Resources.folder as Bitmap;
        Image img_test = Properties.Resources.test as Bitmap;
        Image img_no = Properties.Resources.no_img as Bitmap;
        Image img_user = Properties.Resources.man_icon as Bitmap;
        Image img_rules = Properties.Resources.Rules_of_Fight_Club_icon as Bitmap;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;  


        public SaveToFile()
        {
            InitializeComponent();
            dgvTests.Rows.Add(0, img_folder, "Общая группа");
            dgvTests.Rows.Add(1, img_test, "Тест №1");
            dgvTests.Rows.Add(1, img_test, "Тест №2");
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
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog1.ShowDialog(); 
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
