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
    public partial class EditAnswer : Form
    {

        TestDB.Answers answer_obj;

        public EditAnswer(int answer_id)
        {
            InitializeComponent();
            TestDB.Answers answer = new TestDB.Answers(answer_id);
            tbName.Text = answer.name;
            if (answer.correct == 0) { cbCorrect.Checked = false; } else { cbCorrect.Checked = true; }
            answer_obj = answer;
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
            // Редактируем ответ ответ
            answer_obj.name = tbName.Text;
            if (cbCorrect.Checked == true)
            {
                answer_obj.correct = 1;
            }
            else 
            {
                answer_obj.correct = 0;
            }
            answer_obj.Save();

            EditTest edit_test = (EditTest)Application.OpenForms["EditTest"];
            edit_test.UpdateDgvAnswers(answer_obj.questions_id);
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
