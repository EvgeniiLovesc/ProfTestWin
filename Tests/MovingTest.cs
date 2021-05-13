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
    public partial class MovingTest : Form
    {


        Image img_folder = Properties.Resources.folder as Bitmap;
        Image img_test = Properties.Resources.test as Bitmap;
        Image img_no = Properties.Resources.no_img as Bitmap;
        Image img_user = Properties.Resources.man_icon as Bitmap;
        Image img_rules = Properties.Resources.Rules_of_Fight_Club_icon as Bitmap;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        private int test_id;


        public MovingTest(int test_id)
        {
            InitializeComponent();
            TestDB test = new TestDB(test_id);
            tbText.Text = "Перемещение теста '" + test.name + "' в группу: ";
            this.test_id = test_id;
            TestsGroupDB obj = new TestsGroupDB();
            obj.Fill(); 

            // list групп для перемещения в неё
            Dictionary<string, string> test_group_list_move = new Dictionary<string, string>();
            for (int i = 0; i < obj.list_objects.Count; i++)
            {
                // Исключим из списка удаляемую группу, как?
                test_group_list_move.Add(obj.list_objects[i].id.ToString(), obj.list_objects[i].name);
            }

            cbTestGroupMove.DataSource = new BindingSource(test_group_list_move, null);           
            cbTestGroupMove.DisplayMember = "Value";
            cbTestGroupMove.ValueMember = "Key";
            cbTestGroupMove.SelectedIndex = 0;
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
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите переместить тест?", "Вопрос", MessageBoxButtons.YesNo);
            switch(dr)
            {
               case DialogResult.Yes:
                    // Тесты текущей группы
                    TestDB test = new TestDB(this.test_id);

                    // Id выбранной группы
                    int group_to_move_id = Convert.ToInt32(((KeyValuePair<string, string>)cbTestGroupMove.SelectedItem).Key);

                    this.Close();

                    // Перемещаем
                    test.MoveToGroupId(group_to_move_id);                    
             
                    // Обновим dgv
                    MainForm main_fm = (MainForm)Application.OpenForms["MainForm"];
                    main_fm.UpdateDGV_Tests();

                    break;

               case DialogResult.No:
                  break;
            }
            this.Close();
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
