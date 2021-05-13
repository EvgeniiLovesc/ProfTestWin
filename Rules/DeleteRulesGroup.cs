using NK_TEST.Rules;
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
    public partial class DeleteRulesGroup : Form
    {

        public DeleteRulesGroup()
        {
            InitializeComponent();
            RulesGroupDB obj = new RulesGroupDB();
            rbDeleteUser.Checked = true;
            obj.Fill();      
            
            // list групп для удаления
            Dictionary<string, string> user_groups_list_delete = new Dictionary<string, string>();
            for (int i = 0; i < obj.list_objects.Count; i++)
            {
                user_groups_list_delete.Add(obj.list_objects[i].id.ToString(), obj.list_objects[i].name);
            }
            // list групп для перемещения в неё
            Dictionary<string, string> user_group_list_move = new Dictionary<string, string>();
            for (int i = 0; i < obj.list_objects.Count; i++)
            {
                // Исключим из списка удаляемую группу, как?
                user_group_list_move.Add(obj.list_objects[i].id.ToString(), obj.list_objects[i].name);
            }


            cbUserGroupDelete.DataSource = new BindingSource(user_groups_list_delete, null);           
            cbUserGroupDelete.DisplayMember = "Value";
            cbUserGroupDelete.ValueMember = "Key";
            cbUserGroupDelete.SelectedIndex = 0;


            cbUserGroupMove.DataSource = new BindingSource(user_group_list_move, null);           
            cbUserGroupMove.DisplayMember = "Value";
            cbUserGroupMove.ValueMember = "Key";
            cbUserGroupMove.SelectedIndex = 0;
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            this.Close();
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить объект?", "Вопрос", MessageBoxButtons.YesNo);
            switch(dr)
            {
               case DialogResult.Yes:
                    // Получим список правил данной группы
                    RulesDB rdb = new RulesDB();
                    int group_from_id = Convert.ToInt32(((KeyValuePair<string, string>)cbUserGroupDelete.SelectedItem).Key);
                    // Если удаляем пользователей вместе с группой
                    if (rbDeleteUser.Checked == true) 
                    {
                        rdb.DeleteByGroupId(group_from_id);
                    }

                    // Если перемещаем правила группы в другую группу
                    if (rbMoveUser.Checked == true) 
                    {
                        int group_to_move_id = Convert.ToInt32(((KeyValuePair<string, string>)cbUserGroupMove.SelectedItem).Key);                                            
                        rdb.MoveToGroupId(group_from_id, group_to_move_id);                    
                    }                    
                    // Затем удаляем группу из user_group
                    RulesGroupDB obj = new RulesGroupDB();
                    obj.Delete(Convert.ToInt32(((KeyValuePair<string,string>)cbUserGroupDelete.SelectedItem).Key));                   

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
