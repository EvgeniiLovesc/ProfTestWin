using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace NK_TEST.Users
{
    public partial class ResultOnRulesPrintDialog : Form
    {

        Image img_folder = Properties.Resources.folder as Bitmap;
        Image img_test = Properties.Resources.test as Bitmap;
        Image img_no = Properties.Resources.no_img as Bitmap;
        Image img_user = Properties.Resources.man_icon as Bitmap;
        Image img_rules = Properties.Resources.Rules_of_Fight_Club_icon as Bitmap;
        private Font printFont;
        private System.IO.StreamReader streamToPrint;

        public ResultOnRulesPrintDialog()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss"; 

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm:ss"; 


            dgvTests.Rows.Add(0, img_folder, "Общая группа");
            dgvTests.Rows.Add(1, img_test, "Тест №1");
            dgvTests.Rows.Add(1, img_test, "Тест №2");

            dgvUsers.Rows.Add(0, img_folder, "Пользователи группа №1");
            dgvUsers.Rows.Add(0, img_user, "Иванов И.И.");
            dgvUsers.Rows.Add(1, img_user, "Петров П.П.");

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
            System.Drawing.Printing.PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            PrintDialog pdi = new PrintDialog();
            pdi.Document = pd;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
            else
            {
                MessageBox.Show("Print Cancelled");
            }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage && ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
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
