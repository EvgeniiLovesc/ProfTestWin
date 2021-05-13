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
    public partial class EditTest : Form
    {


        Image img_folder = Properties.Resources.folder as Bitmap;
        Image img_test = Properties.Resources.test as Bitmap;
        Image img_no = Properties.Resources.no_img as Bitmap;
        Image img_user = Properties.Resources.man_icon as Bitmap;
        Image img_rules = Properties.Resources.Rules_of_Fight_Club_icon as Bitmap;

        TestDB test;


        public EditTest(string test_name)
        {
            InitializeComponent();
            // Получим только что созданный тест
            TestDB test = new TestDB(test_name);
            tbTestName.Text = test_name;
            string a = test.name;
            this.test = test;
            
            // Создаём первый вопрос по дефолту
            dgvQuestionsList.Rows.Add(
                test.questions_list[0].id,
                0,
                test.questions_list[0].name
            );
            tbQuestionName.Text = test.questions_list[0].name;

        }

        public EditTest(int id)
        {
            InitializeComponent();
            
            // Получим только что созданный тест
            TestDB test = new TestDB(id);
            this.test = test;
            this.Text = "Редактирование теста '" + test.name + "'";
            tbTestName.Text = test.name;
            // Заполняем список вопросов
            for (int i = 0; i < test.questions_list.Count; i++)
            {
                dgvQuestionsList.Rows.Add(
                    test.questions_list[i].id,
                    i+1,
                    test.questions_list[i].name
                );            
            }
            tbQuestionName.Text = test.questions_list[0].name;


        }

        private void EditTest_Load(object sender, EventArgs e)
        {
            //wbQuestion.Navigate("C:\\Server\\data\\htdocs\\Repositories\\NKTest\\NK_TEST\\WinApp\\NK_TEST\\Resources\\Editor\\CKEDITOR.htm");
            //wbQuestion.Navigate(@".\\Resources\\Editor\\CKEDITOR.htm");
            wbQuestion.Navigate(System.IO.Path.Combine(Application.StartupPath, "Resources\\Editor\\CKEDITOR.htm"));
            Application.DoEvents();
            wbQuestion.Document.InvokeScript("InitEditor");
            //lblTemp.Text = Application.StartupPath.ToString();
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
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.openFileDialogImg1 = new System.Windows.Forms.OpenFileDialog
            {
                DefaultExt = "img",
                Title = "Выберите файл в формате .img, .png",
                Filter = "Image files (*.img)|*.img"
            };

            openFileDialogImg1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTestDoc_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Print(1);
        }

        private void btnNewTest_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Тест успешно сохранён", "Сохранение", MessageBoxButtons.OK);
            // Обновим dataGridTests
            MainForm main_fm = (MainForm)Application.OpenForms["MainForm"];
            main_fm.UpdateDGV_Tests();

            this.Close();



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить вопрос?", "Вопрос", MessageBoxButtons.YesNo);
            switch(dr)
            {
               case DialogResult.Yes:
                    int selectedrowindex = dgvQuestionsList.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvQuestionsList.Rows[selectedrowindex];
                    int selected_id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    // Удаляем вопрос из БД
                    this.test.questions_list[selectedrowindex].Delete(selected_id);
                    // Удаляем вопрос из question_list                  
                    this.test.questions_list.RemoveAt(selectedrowindex); 
                    // Обновляем dgv
                    FillDGVQuestions();
                    // Зададим выбранную строку в dgv
                    dgvQuestionsList.Rows[0].Selected = true;
                    dgvQuestionsList.Rows[0].Cells[0].Selected = true;
                    dgvQuestionsList.FirstDisplayedScrollingRowIndex = 0;

                  break;
               case DialogResult.No:
                  break;
            }
        }

        private void btnSaveInFile_Click(object sender, EventArgs e)
        {
            AboutTest at = new AboutTest();
            at.Show();
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            SettingsTest st = new SettingsTest();
            st.Show();
        }

        private void wbQuestion_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //
            TestDB.Question new_question = new TestDB.Question();
            new_question.name = "Вопрос № " + dgvQuestionsList.Rows.Count.ToString();
            new_question.test_id = this.test.id;
            // Запишем новый вопрос в БД            
            new_question.AddToDB();
            new_question = null;
            //Получим новый вопрос с присвоенным Id
            TestDB.Question current_question = new TestDB.Question();
            current_question.GetLastByTestId(this.test.id);

            this.test.questions_list.Add(current_question);
            // Обновим dgv
            FillDGVQuestions();
            // Установим selector на последний вопрос и загрузим тело вопроса, фотографии и ответы этого вопроса
            //dgvQuestionsList.SelectedRow
            dgvQuestionsList.ClearSelection();
            int nRowIndex = dgvQuestionsList.Rows.Count - 1;
            int nColumnIndex = 0;
            dgvQuestionsList.Rows[nRowIndex].Selected = true;
            dgvQuestionsList.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;
            dgvQuestionsList.FirstDisplayedScrollingRowIndex = nRowIndex;
            // Загрузим содержание вопроса
            //1. Название
            tbQuestionName.Text = current_question.name;
            //2. Фотографии
            //...
            //3. Тело вопроса
            //wbQuestion.DocumentText = current_question.description;
            //4. dgv с ответами
            //...

        }

        public void FillDGVQuestions() 
        {   
            dgvQuestionsList.Rows.Clear(); 
            if (1 == 1) 
            {
                for (int i = 0; i < this.test.questions_list.Count; i++)
                {

                    dgvQuestionsList.Rows.Add(
                        this.test.questions_list[i].id,
                        i+1,
                        this.test.questions_list[i].name
                    );
                }           
            }
            dgvQuestionsList.Refresh();
        }

        private void tbQuestionName_TextChanged(object sender, EventArgs e)
        {

        
        }
        private void dgvQuestionsList_SelectionChanged(object sender, EventArgs e)
        {
            int selectedrowindex = 0;
            if (dgvQuestionsList.Rows.Count > 0)
            {
                if (dgvQuestionsList.SelectedRows.Count > 0)
                {
                    selectedrowindex = dgvQuestionsList.SelectedCells[0].RowIndex; //!!!!
                    DataGridViewRow selectedRow = dgvQuestionsList.Rows[selectedrowindex];
                }

            }

            // Загрузим содержание вопроса
            //1. Название
            tbQuestionName.Text = this.test.questions_list[selectedrowindex].name;
            //2. Фотографии
            //...
            //3. Тело вопроса
            //wbQuestion.DocumentText = current_question.description;
            //4. dgv с ответами
            //...
        }

        private void tbQuestionName_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvQuestionsList.Rows.Count > 0)
                {
                    int selectedrowindex = dgvQuestionsList.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvQuestionsList.Rows[selectedrowindex];
                    //selectedRow.Cells["tb_Name"].Value = tbQuestionName.Text;
                    dgvQuestionsList[2, selectedrowindex].Value = tbQuestionName.Text;
                }
            }
        }
    }
}
