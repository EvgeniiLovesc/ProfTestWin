using NK_TEST.Rules;
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
    public partial class DeleteTestsGroup : Form
    {

        public DeleteTestsGroup()
        {
            InitializeComponent();
            TestsGroupDB obj = new TestsGroupDB();
            rbDeleteTest.Checked = true;
            obj.Fill();      
            
            // list групп для удаления
            Dictionary<string, string> test_groups_list_delete = new Dictionary<string, string>();
            for (int i = 0; i < obj.list_objects.Count; i++)
            {
                test_groups_list_delete.Add(obj.list_objects[i].id.ToString(), obj.list_objects[i].name);
            }
            // list групп для перемещения в неё
            Dictionary<string, string> test_group_list_move = new Dictionary<string, string>();
            for (int i = 0; i < obj.list_objects.Count; i++)
            {
                // Исключим из списка удаляемую группу, как?
                test_group_list_move.Add(obj.list_objects[i].id.ToString(), obj.list_objects[i].name);
            }

            cbTestGroupDelete.DataSource = new BindingSource(test_groups_list_delete, null);           
            cbTestGroupDelete.DisplayMember = "Value";
            cbTestGroupDelete.ValueMember = "Key";
            cbTestGroupDelete.SelectedIndex = 0;


            cbTestGroupMove.DataSource = new BindingSource(test_group_list_move, null);           
            cbTestGroupMove.DisplayMember = "Value";
            cbTestGroupMove.ValueMember = "Key";
            cbTestGroupMove.SelectedIndex = 0;
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            this.Close();
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить объект?", "Вопрос", MessageBoxButtons.YesNo);
            switch(dr)
            {
               case DialogResult.Yes:
                    // Получим список правил данной группы
                    TestsDB rdb = new TestsDB();
                    int group_from_id = Convert.ToInt32(((KeyValuePair<string, string>)cbTestGroupDelete.SelectedItem).Key);
                    // Если удаляем тесты вместе с группой
                    if (rbDeleteTest.Checked == true) 
                    {
                        rdb.DeleteByGroupId(group_from_id);
                    }

                    // Если перемещаем тесты группы в другую группу
                    if (rbMoveTest.Checked == true) 
                    {
                        int group_to_move_id = Convert.ToInt32(((KeyValuePair<string, string>)cbTestGroupMove.SelectedItem).Key);                                            
                        rdb.MoveToGroupId(group_from_id, group_to_move_id);                    
                    }                    
                    // Затем удаляем группу из test_group
                    TestsGroupDB obj = new TestsGroupDB();
                    obj.Delete(Convert.ToInt32(((KeyValuePair<string,string>)cbTestGroupDelete.SelectedItem).Key));                   

                    // Обновим dgv
                    MainForm main_fm = (MainForm)Application.OpenForms["MainForm"];
                    main_fm.UpdateDGV_Rules();

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

        private void cbUserTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
