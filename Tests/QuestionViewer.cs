using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NK_TEST.Tests
{
    public partial class QuestionViewer : Form
    {


        object[] question_body = new object[1];

        public QuestionViewer(int question_id)
        {
            InitializeComponent();

            #region Скрываем всё по дефолту
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

            lblImageName1.Visible = false;
            lblImageName2.Visible = false;
            lblImageName3.Visible = false;
            lblImageName4.Visible = false;

            lblInputAnswer.Visible = false;
            tbInputAnswer.Visible = false;

            cbAnswer1.Visible = false;
            cbAnswer2.Visible = false;
            cbAnswer3.Visible = false;
            cbAnswer4.Visible = false;
            #endregion

            TestDB.Question quest_obj = new TestDB.Question(question_id);

            //1. Фотографии
            #region Фотографии
            if (quest_obj.images_list.Count >= 1) 
            {
                if (quest_obj.images_list[0].name.Length > 20)
                {
                    lblImageName1.Text = quest_obj.images_list[0].name.Substring(0, 20);
                }
                else 
                {
                    lblImageName1.Text = quest_obj.images_list[0].name;
                }

                pictureBox1.Visible = true;
                //pictureBox1.Image = quest_obj.images_list[0].getImage();
                lblImageName1.Visible = true;
            }

            if (quest_obj.images_list.Count >= 2)
            {
                if (quest_obj.images_list[1].name.Length > 20)
                {
                    lblImageName2.Text = quest_obj.images_list[1].name.Substring(0, 20);
                }
                else 
                {
                    lblImageName2.Text = quest_obj.images_list[1].name;
                }
                pictureBox2.Visible = true;
                //pictureBox2.Image = quest_obj.images_list[1].getImage();
                lblImageName2.Visible = true;
            }

            if (quest_obj.images_list.Count >= 3)
            {
                if (quest_obj.images_list[2].name.Length > 20)
                {
                    lblImageName3.Text = quest_obj.images_list[2].name.Substring(0, 20);
                }
                else 
                {
                    lblImageName3.Text = quest_obj.images_list[2].name;
                }
                pictureBox3.Visible = true;
                //pictureBox3.Image = quest_obj.images_list[2].getImage();
                lblImageName3.Visible = true;
            }

            if (quest_obj.images_list.Count >= 4)
            {
                if (quest_obj.images_list[3].name.Length > 20)
                {
                    lblImageName4.Text = quest_obj.images_list[3].name.Substring(0, 20);
                }
                else 
                {
                    lblImageName4.Text = quest_obj.images_list[3].name;
                }
                pictureBox4.Visible = true;
                pictureBox4.Image = quest_obj.images_list[3].getImage();
                lblImageName4.Visible = true;
            }
            #endregion

            //2. Тело вопроса
            #region Тепло вопроса
            question_body[0] = quest_obj.description;
            wbQuestionDescription.Navigate(System.IO.Path.Combine(Application.StartupPath, "Resources\\QuestionViewer.htm"));
            Application.DoEvents();
            wbQuestionDescription.Document.InvokeScript("SetValue", question_body);
            #endregion

            //3. Ответы
            #region Ответы
            if ((quest_obj.answers_list.Count >= 1) && (quest_obj.type_id != 3)) 
            {
                cbAnswer1.Visible = true;
                cbAnswer1.Text = quest_obj.answers_list[0].name;
            }

            if ((quest_obj.answers_list.Count >= 2) && (quest_obj.type_id != 3)) 
            {
                cbAnswer2.Visible = true;
                cbAnswer2.Text = quest_obj.answers_list[1].name;
            }

            if ((quest_obj.answers_list.Count >= 3) && (quest_obj.type_id != 3)) 
            {
                cbAnswer3.Visible = true;
                cbAnswer3.Text = quest_obj.answers_list[2].name;
            }

            if ((quest_obj.answers_list.Count >= 4) && (quest_obj.type_id != 3)) 
            {
                cbAnswer4.Visible = true;
                cbAnswer4.Text = quest_obj.answers_list[3].name;
            }
            #endregion

            //4. Тип вопроса
            #region Тип вопроса
            if (quest_obj.type_id == 1) 
            {
                lblTypeQuestion.Text = "Выберите 1 правильный ответ";

            }
            if (quest_obj.type_id == 2) 
            { 
                lblTypeQuestion.Text = "Выберите несколько правильных ответов"; 
            }
            if (quest_obj.type_id == 3)
            {
                lblTypeQuestion.Text = "Впишите ответ в поле ниже";
                lblInputAnswer.Visible = true;
                tbInputAnswer.Visible = true;

                cbAnswer1.Visible = false;
                cbAnswer2.Visible = false;
                cbAnswer3.Visible = false;
                cbAnswer4.Visible = false;
            }
            #endregion

            //5. Запускаем фоновый професс загруки фотографии теста

        }


    }
}
