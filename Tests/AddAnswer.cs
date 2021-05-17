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
    public partial class AddAnswer : Form
    {

        int question_id;
        int type_id;

        public AddAnswer(int question_id, int type_id)
        {
            InitializeComponent();
            this.question_id = question_id;
            this.type_id = type_id;
      
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
            // Создаём ответ
            TestDB.Answers answer = new TestDB.Answers();
            answer.name = tbName.Text;
            answer.questions_id = this.question_id;
            if (cbCorrect.Checked == true)
            {
                answer.correct = 1;
            }
            else 
            {
                answer.correct = 0;
            }
            answer.AddToDB();

            EditTest edit_test = (EditTest)Application.OpenForms["EditTest"];
            edit_test.UpdateDgvAnswers(this.question_id);
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
