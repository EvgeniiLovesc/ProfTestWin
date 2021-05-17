using NK_TEST.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NK_TEST.Users
{
    public partial class EditTest : Form
    {

        #region СВОЙСТВА EditTest
        Image img_folder = Properties.Resources.folder as Bitmap;
        Image img_test = Properties.Resources.test as Bitmap;
        Image img_no = Properties.Resources.no_img as Bitmap;
        Image img_user = Properties.Resources.man_icon as Bitmap;
        Image img_rules = Properties.Resources.Rules_of_Fight_Club_icon as Bitmap;

        int question_counts = 0;
        object[] question_body = new object[1];
        bool isDelete = false;
        bool isFirstRun = true;

        TestDB test;
        #endregion


        // ----------------------------------------------------------------------------------------
        // ЗАГРУЗКА -------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------
        #region MAIN
        public EditTest(string test_name)
        {
            InitializeComponent();

            // Получим только что созданный тест
            TestDB test = new TestDB(test_name);
            tbTestName.Text = test_name;
            this.test = test;
            
            // Создаём первый вопрос по дефолту
            dgvQuestionsList.Rows.Add(
                test.questions_list[0].id,
                0,
                test.questions_list[0].name
            );
            // Заголовок вопроса
            tbQuestionName.Text = test.questions_list[0].name;
            // Тело вопроса
            question_body[0] = this.test.questions_list[0].description;
            wbQuestion.Document.InvokeScript("setContent", question_body);
            wbQuestion.Document.InvokeScript("setContent", question_body);

            this.question_counts = dgvQuestionsList.Rows.Count;

            // Заполним вопрос в редактор из БД
            question_body[0] = this.test.questions_list[0].description;
            wbQuestion.Navigate(System.IO.Path.Combine(Application.StartupPath, "Resources\\Editor\\CKEDITOR.htm"));
            wbQuestion.Document.InvokeScript("InitEditor", question_body); 
            Application.DoEvents();

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
            this.question_counts = dgvQuestionsList.Rows.Count;


            // Заполним тип вопроса
            if (test.questions_list[0].type_id == 1) { rbOneAnswer.Checked = true; }
            if (test.questions_list[0].type_id == 2) { rbManyAnswers.Checked = true; }
            if (test.questions_list[0].type_id == 3) { rbTextValue.Checked = true; }

            // Заполним ответы к этому вопросу
            FillAnswers(test.questions_list[0]);

            // Заполним вопрос в редактор из БД
            question_body[0] = this.test.questions_list[0].description;
            wbQuestion.Navigate(System.IO.Path.Combine(Application.StartupPath, "Resources\\Editor\\CKEDITOR.htm"));
            wbQuestion.Document.InvokeScript("InitEditor", question_body); 
            Application.DoEvents();

            //Заполним изображения вопроса
            getQuestionImageList(test.questions_list[0].id);

        }

        private void EditTest_Load(object sender, EventArgs e)
        {

        }
        #endregion

        // ----------------------------------------------------------------------------------------
        // КНОПКИ В ВЕРХНЕМ МЕНЮ ------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------
        #region КНОПКИ
        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnTestDoc_Click(object sender, EventArgs e)
        {
            int question_id = test.questions_list[getSelectedQuestionIndex()].id;            
            QuestionViewer obj = new QuestionViewer(question_id);
            obj.Show();
        }

        private void btnNewTest_Click(object sender, EventArgs e)
        {
            
            // Сохраним тест в БД
            this.test.questions_list[getSelectedQuestionIndex()].description = wbQuestion.Document.InvokeScript("getContent").ToString();
            this.test.date_last_saved = DateTime.Now;
            this.test.Save();

            DialogResult dr = MessageBox.Show("Тест успешно сохранён", "Сохранение", MessageBoxButtons.OK);
            // Обновим dataGridTests
            MainForm main_fm = (MainForm)Application.OpenForms["MainForm"];
            main_fm.UpdateDGV_Tests();

            //this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvQuestionsList.Rows.Count > 1)
            {
                DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить вопрос?", "Вопрос", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:

                        DataGridViewRow selectedRow = dgvQuestionsList.Rows[getSelectedQuestionIndex()];
                        int selected_id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                        // Зададим выбранную строку в dgv
                        this.isDelete = true;

                        // Удаляем вопрос из БД
                        this.test.questions_list[getSelectedQuestionIndex()].Delete(selected_id);
                        // Удаляем вопрос из question_list                  
                        this.test.questions_list.RemoveAt(getSelectedQuestionIndex());
                        this.question_counts = dgvQuestionsList.Rows.Count - 1;
                        // Обновляем dgv
                        FillDGVQuestions();


                        break;
                    case DialogResult.No:
                        break;
                }

            }
            else 
            {
                MessageBox.Show("Вы не можете удалить единственный вопрос теста.");
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //
            TestDB.Question new_question = new TestDB.Question();
            new_question.name = "Новый";
            new_question.test_id = this.test.id;
            new_question.description = "";
            new_question.type_id = 1; // 1 правильный ответ
            // Запишем новый вопрос в БД            
            new_question.AddToDB();
            //new_question = null;
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
            lblNumQuestion.Text = (nRowIndex+1).ToString();
            // Загрузим содержание вопроса
            //1. Название
            tbQuestionName.Text = current_question.name;
            //2. Фотографии
            //...
            //3. Тело вопроса
            question_body[0] = current_question.description;
            wbQuestion.Document.InvokeScript("setContent", question_body);
            //4. dgv с ответами
            //...

        }

        #endregion

        // ----------------------------------------------------------------------------------------
        // ВОПРОСЫ --------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------
        #region ВОПРОСЫ 
        // Заполняем список изображений у вопроса
        public void getQuestionImageList(int question_id) 
        {
            ImageList image_box = new ImageList();
            image_box.ImageSize = new Size(120, 100);
            pbImage1.Visible = false;
            pbImage2.Visible = false;
            pbImage3.Visible = false;
            pbImage4.Visible = false;
            Image1Name.Visible = false;
            Image2Name.Visible = false;
            Image3Name.Visible = false;
            Image4Name.Visible = false;
            int index = getSelectedQuestionIndex();


            if (test.questions_list[getSelectedQuestionIndex()].images_list.Count >= 1) 
            {
                TestDB.Images obj2 = test.questions_list[getSelectedQuestionIndex()].images_list[0];
                if (test.questions_list[getSelectedQuestionIndex()].images_list[0].name.Length > 20)
                {
                    Image1Name.Text = test.questions_list[getSelectedQuestionIndex()].images_list[0].name.Substring(0, 20);
                }
                else 
                {
                    Image1Name.Text = test.questions_list[getSelectedQuestionIndex()].images_list[0].name;
                }

                pbImage1.Visible = true;
                Image1Name.Visible = true;
            }

            if (test.questions_list[getSelectedQuestionIndex()].images_list.Count >= 2)
            {
                if (test.questions_list[getSelectedQuestionIndex()].images_list[1].name.Length > 20)
                {
                    Image2Name.Text = test.questions_list[getSelectedQuestionIndex()].images_list[1].name.Substring(0, 20);
                }
                else 
                {
                    Image2Name.Text = test.questions_list[getSelectedQuestionIndex()].images_list[1].name;
                }
                pbImage2.Visible = true;
                Image2Name.Visible = true;
            }

            if (test.questions_list[getSelectedQuestionIndex()].images_list.Count >= 3)
            {
                if (test.questions_list[getSelectedQuestionIndex()].images_list[2].name.Length > 20)
                {
                    Image3Name.Text = test.questions_list[getSelectedQuestionIndex()].images_list[2].name.Substring(0, 20);
                }
                else 
                {
                    Image3Name.Text = test.questions_list[getSelectedQuestionIndex()].images_list[2].name;
                }
                pbImage3.Visible = true;
                Image3Name.Visible = true;
            }

            if (test.questions_list[getSelectedQuestionIndex()].images_list.Count >= 4)
            {
                if (test.questions_list[getSelectedQuestionIndex()].images_list[3].name.Length > 20)
                {
                    Image1Name.Text = test.questions_list[getSelectedQuestionIndex()].images_list[3].name.Substring(0, 20);
                }
                else 
                {
                    Image1Name.Text = test.questions_list[getSelectedQuestionIndex()].images_list[3].name;
                }
                Image4Name.Text = test.questions_list[question_id].images_list[3].name.Substring(0, 20);
                pbImage4.Visible = true;
                Image4Name.Visible = true;
            }

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

        private void dgvQuestionsList_SelectionChanged(object sender, EventArgs e)
        {
            // Сохраним текущий вопрос в БД перед переходом на другой
            if (!isFirstRun) 
            {
                startProgress();
                lblNumQuestion.Text = (getSelectedQuestionIndex() + 1).ToString();
                // Загрузим содержание вопроса
                //1. Название
                tbQuestionName.Text = this.test.questions_list[getSelectedQuestionIndex()].name;
                //2. Фотографии
                getQuestionImageList(test.questions_list[getSelectedQuestionIndex()].id);
                //3. Тело вопроса
                question_body[0] = this.test.questions_list[getSelectedQuestionIndex()].description;
                wbQuestion.Document.InvokeScript("setContent", question_body);
                //4. Тип ответа
                if (this.test.questions_list[getSelectedQuestionIndex()].type_id == 1) rbOneAnswer.Checked = true;
                if (this.test.questions_list[getSelectedQuestionIndex()].type_id == 2) rbManyAnswers.Checked = true;
                if (this.test.questions_list[getSelectedQuestionIndex()].type_id == 3) rbTextValue.Checked = true;

                //5. dgv с ответами
                UpdateDgvAnswers(this.test.questions_list[getSelectedQuestionIndex()].id);

                finishProgress();
            }
            isFirstRun = false;

        }

        private void tbQuestionName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvQuestionsList.Rows.Count > 0)
                {
                    dgvQuestionsList[2, getSelectedQuestionIndex()].Value = tbQuestionName.Text;
                    // Обновим в БД
                    this.test.questions_list[getSelectedQuestionIndex()].name = tbQuestionName.Text;
                    this.test.questions_list[getSelectedQuestionIndex()].Save();
                }
            }
        }

        private void btnGetImage1_Click(object sender, EventArgs e)
        {
            getQuestionImageList(test.questions_list[getSelectedQuestionIndex()].id);
        }

        private void pbImage1_Click(object sender, EventArgs e)
        {
            int img_id = test.questions_list[getSelectedQuestionIndex()].images_list[0].id;
            ImageDetail img_window = new ImageDetail(img_id);
            img_window.Show();
        }

        private void pbImage2_Click(object sender, EventArgs e)
        {
            int img_id = test.questions_list[getSelectedQuestionIndex()].images_list[1].id;           
            ImageDetail img_window = new ImageDetail(img_id);
            img_window.Show();
        }

        private void pbImage3_Click(object sender, EventArgs e)
        {
            int img_id = test.questions_list[getSelectedQuestionIndex()].images_list[2].id;
            ImageDetail img_window = new ImageDetail(img_id);
            img_window.Show();
        }

        private void pbImage4_Click(object sender, EventArgs e)
        {
            int img_id = test.questions_list[getSelectedQuestionIndex()].images_list[3].id;
            ImageDetail img_window = new ImageDetail(img_id);
            img_window.Show();
        }

        #endregion

        // ----------------------------------------------------------------------------------------
        // ОТВЕТЫ ---------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------
        #region ОТВЕТЫ
        // ТИПЫ ОТВЕТОВ ANSWERS ------------------------------------------------------------------------------
        public int getSelectedQuestionIndex() 
        {
            int selectedrowindex = -1;

            // Если было удаление
            if (this.isDelete)
            {
                selectedrowindex = 0;
                isDelete = false;
            }
            else 
            {
                if (dgvQuestionsList.CurrentRow != null)
                {
                    selectedrowindex = dgvQuestionsList.CurrentRow.Index;
                }
                else 
                {
                    selectedrowindex = 0;
                }
            }
            return selectedrowindex;
        }

        private void rbOneAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvQuestionsList.SelectedRows.Count > 0) 
            {

                DataGridViewRow selectedRow = dgvQuestionsList.Rows[getSelectedQuestionIndex()];
                int question_id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                this.test.questions_list[question_id].type_id = 1;
            }
        }

        private void rbManyAnswers_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvQuestionsList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvQuestionsList.Rows[getSelectedQuestionIndex()];
                int question_id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                this.test.questions_list[question_id].type_id = 2;
            }
        }

        private void rbTextValue_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvQuestionsList.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvQuestionsList.Rows[getSelectedQuestionIndex()];
                int question_id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                this.test.questions_list[question_id].type_id = 3;

            }
        }

        // ДОБАВИТЬ, ИЗМЕНИТЬ, УДАЛИТЬ ОТВЕТ ANSWERS ---------------------------------------------------------

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            int type_id = 0;
            if (rbOneAnswer.Checked == true){ type_id = 1; }
            if (rbManyAnswers.Checked == true){ type_id = 2; }
            if (rbTextValue.Checked == true){ type_id = 3; }

            int question_id = this.test.questions_list[getSelectedQuestionIndex()].id;
            AddAnswer win = new AddAnswer(question_id, type_id);
            win.Show();
        }

        private void btnEditAnswer_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dgvAnswers.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvAnswers.Rows[selectedrowindex];
            int answer_id = Convert.ToInt32(selectedRow.Cells["id_answer"].Value);  

            EditAnswer obj = new EditAnswer(answer_id);
            obj.Show();
        }

        private void btnDeleteAnswer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить ответ?", "Вопрос", MessageBoxButtons.YesNo);
            switch(dr)
            {
               case DialogResult.Yes:
                    int selectedrowindex = dgvAnswers.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvAnswers.Rows[selectedrowindex];
                    int answer_id = Convert.ToInt32(selectedRow.Cells["id_answer"].Value); 
                    TestDB.Answers obj = new TestDB.Answers(answer_id);
                    obj.Delete(answer_id);
                    UpdateDgvAnswers(obj.questions_id);
                    obj = null;
                    break;
               case DialogResult.No:
                  break;
            }

        }

        // ОБНОВИТЬ DGV ОТВЕТОВ ANSWERS ----------------------------------------------------------------------
        private void FillAnswers(TestDB.Question question) 
        {
            if (question.type_id == 1)
            {
                dgvAnswers.Rows.Clear();
                for (int i = 0; i < question.answers_list.Count; i++)
                {
                    dgvAnswers.Rows.Add(
                        question.answers_list[i].id,
                        question.answers_list[i].correct,
                        question.answers_list[i].name
                    );
                }
                tabControlAnswers.SelectedIndex = 0;
                rbOneAnswer.Checked = true;
            }
            if (question.type_id == 2)
            {
                dgvAnswers.Rows.Clear();
                for (int i = 0; i < question.answers_list.Count; i++)
                {
                    dgvAnswers.Rows.Add(
                        question.answers_list[i].correct,
                        question.answers_list[i].position,
                        question.answers_list[i].name
                    );
                }
                tabControlAnswers.SelectedIndex = 0;
                rbManyAnswers.Checked = true;
            }
        }

        public void UpdateDgvAnswers(int question_id) 
        {
            int correct_answers_count = 0;
            dgvAnswers.Rows.Clear();            
            TestDB.Question question = new TestDB.Question(question_id);
            for (int i = 0; i < question.answers_list.Count; i++)
            {
                dgvAnswers.Rows.Add(
                    question.answers_list[i].id,
                    question.answers_list[i].correct,
                    question.answers_list[i].name
                );

                if (question.answers_list[i].correct == 1){ correct_answers_count += 1; }
            }

            dgvAnswers.Refresh();
            // Если есть более 1го правильного ответа, автоматически переводим тип вопроса в "1 и более"
            if (correct_answers_count > 1)
            {
                rbManyAnswers.Checked = true;
                rbOneAnswer.Enabled = false;
            }
            else 
            {
                rbOneAnswer.Enabled = true;
            }


        }


        #endregion

        // ----------------------------------------------------------------------------------------
        // PROGRESS BAR'S -------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------
        #region PROGRESS BAR'S        
        public void startProgress() 
        {
            progressSaveToDB.Visible = true;
            if (backgroundWorker.IsBusy != true) backgroundWorker.RunWorkerAsync();
        }

        public void finishProgress() 
        {
            if (backgroundWorker.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker.CancelAsync();
                progressSaveToDB.Visible = false;
            }        
        }
        
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            //test.Save();

            for (int i = 1; i <= 10; i++) // 0..90%
            {

                if (worker.CancellationPending == true)
                {
                    worker.ReportProgress(100); // полная загрузка
                }

                worker.ReportProgress(i * 10);
                System.Threading.Thread.Sleep(50);

            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressSaveToDB.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        #endregion

        // ----------------------------------------------------------------------------------------
        //  -------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------
    }
}
