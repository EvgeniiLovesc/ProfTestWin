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
    public partial class UserTypes : Form
    {


        public UserTypes(int type_selected_id)
        {
            InitializeComponent();
            int index = type_selected_id;
            TypeUserDB obj = new TypeUserDB();
            obj.Fill();      
            
         
            Dictionary<string, string> user_types_list = new Dictionary<string, string>();
            for (int i = 0; i < obj.list_objects.Count; i++)
            {
                user_types_list.Add(obj.list_objects[i].id.ToString(), obj.list_objects[i].name);
            }

            cbUserTypes.DataSource = new BindingSource(user_types_list, null);           
            cbUserTypes.DisplayMember = "Value";
            cbUserTypes.ValueMember = "Key";
            cbUserTypes.SelectedIndex = index;

            // Заполним дефолтные параметры
            description.Text = obj.list_objects[0].description;
            perm_test_create.Checked = obj.list_objects[0].perm_test_create;
            perm_test_edit.Checked = obj.list_objects[0].perm_test_edit;
            perm_test_delete.Checked = obj.list_objects[0].perm_test_delete;
            perm_protocol_create.Checked = obj.list_objects[0].perm_protocol_create;
            perm_protocol_delete.Checked = obj.list_objects[0].perm_protocol_delete;
            perm_set_examiner.Checked = obj.list_objects[0].perm_set_examiner;
            perm_user_management.Checked = obj.list_objects[0].perm_user_management;
            m_yk.Checked = obj.list_objects[0].m_yk;
            m_pk.Checked = obj.list_objects[0].m_pk;
            m_vik.Checked = obj.list_objects[0].m_vik;
            m_pvk.Checked = obj.list_objects[0].m_pvk;
            m_ek.Checked = obj.list_objects[0].m_ek;
            m_mk.Checked = obj.list_objects[0].m_mk;
            m_ae.Checked = obj.list_objects[0].m_ae;
            m_tk.Checked = obj.list_objects[0].m_tk;
            m_pvt.Checked = obj.list_objects[0].m_pvt;
            m_yt.Checked = obj.list_objects[0].m_yt;
            m_vd.Checked = obj.list_objects[0].m_vd;
            auto_exam.Checked = obj.list_objects[0].auto_exam;
            o1.Checked = obj.list_objects[0].o1;
            o2.Checked = obj.list_objects[0].o2;
            o3.Checked = obj.list_objects[0].o3;
            o4.Checked = obj.list_objects[0].o4;
            o5.Checked = obj.list_objects[0].o5;
            o6.Checked = obj.list_objects[0].o6;
            o7.Checked = obj.list_objects[0].o7;
            o8.Checked = obj.list_objects[0].o8;
            o9.Checked = obj.list_objects[0].o9;
            o10.Checked = obj.list_objects[0].o10;
            o11.Checked = obj.list_objects[0].o11;
            o12.Checked = obj.list_objects[0].o12;

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
            
            TypeUserDB obj = new TypeUserDB();
            obj.id = Convert.ToInt32(((KeyValuePair<string, string>)cbUserTypes.SelectedItem).Key);
            obj.name = Convert.ToString(((KeyValuePair<string, string>)cbUserTypes.SelectedItem).Value);
            obj.description = description.Text;
            obj.perm_test_create = perm_test_create.Checked;
            obj.perm_test_edit =  perm_test_edit.Checked;
            obj.perm_test_delete = perm_test_delete.Checked;
            obj.perm_protocol_create = perm_protocol_create.Checked;
            obj.perm_protocol_delete = perm_protocol_delete.Checked;
            obj.perm_set_examiner = perm_set_examiner.Checked;
            obj.perm_user_management = perm_user_management.Checked;
            obj.m_yk = m_yk.Checked;
            obj.m_pk = m_pk.Checked;
            obj.m_vik = m_vik.Checked;
            obj.m_pvk = m_pvk.Checked;
            obj.m_ek = m_ek.Checked;
            obj.m_mk = m_mk.Checked;
            obj.m_ae = m_ae.Checked;
            obj.m_tk = m_tk.Checked;
            obj.m_pvt = m_pvt.Checked;
            obj.m_yt = m_yt.Checked;
            obj.m_vd = m_vd.Checked;
            obj.auto_exam = auto_exam.Checked;
            obj.o1 = o1.Checked;
            obj.o2 = o2.Checked;
            obj.o3 = o3.Checked;
            obj.o4 = o4.Checked;
            obj.o5 = o5.Checked;
            obj.o6 = o6.Checked;
            obj.o7 = o7.Checked;
            obj.o8 = o8.Checked;
            obj.o9 = o9.Checked;
            obj.o10 = o10.Checked;
            obj.o11 = o11.Checked;
            obj.o12 = o12.Checked;

            obj.Save();

            //this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTests_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UserTypes_Load(object sender, EventArgs e)
        {
            //cbUserTypes.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            AddUserTypes ut = new AddUserTypes();
            ut.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить объект?", "Вопрос", MessageBoxButtons.YesNo);
            switch(dr)
            {
               case DialogResult.Yes:
                    TypeUserDB obj = new TypeUserDB();
                    obj.Delete(Convert.ToInt32(((KeyValuePair<string,string>)cbUserTypes.SelectedItem).Key));                   

                    UserTypes ut = new UserTypes(1);
                    ut.Show();
                    break;
               case DialogResult.No:
                  break;
            }
        }

        private void cbUserTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int user_type_id = 1;
            int selected_index = 0;
            user_type_id = Convert.ToInt32(((KeyValuePair<string, string>)cbUserTypes.SelectedItem).Key);
            selected_index = cbUserTypes.SelectedIndex;
            TypeUserDB obj = new TypeUserDB(user_type_id);
            description.Text = obj.description;
            perm_test_create.Checked = obj.perm_test_create;
            perm_test_edit.Checked = obj.perm_test_edit;
            perm_test_delete.Checked = obj.perm_test_delete;
            perm_protocol_create.Checked = obj.perm_protocol_create;
            perm_protocol_delete.Checked = obj.perm_protocol_delete;
            perm_set_examiner.Checked = obj.perm_set_examiner;
            perm_user_management.Checked = obj.perm_user_management;
            m_yk.Checked = obj.m_yk;
            m_pk.Checked = obj.m_pk;
            m_vik.Checked = obj.m_vik;
            m_pvk.Checked = obj.m_pvk;
            m_ek.Checked = obj.m_ek;
            m_mk.Checked = obj.m_mk;
            m_ae.Checked = obj.m_ae;
            m_tk.Checked = obj.m_tk;
            m_pvt.Checked = obj.m_pvt;
            m_yt.Checked = obj.m_yt;
            m_vd.Checked = obj.m_vd;
            auto_exam.Checked = obj.auto_exam;
            o1.Checked = obj.o1;
            o2.Checked = obj.o2;
            o3.Checked = obj.o3;
            o4.Checked = obj.o4;
            o5.Checked = obj.o5;
            o6.Checked = obj.o6;
            o7.Checked = obj.o7;
            o8.Checked = obj.o8;
            o9.Checked = obj.o9;
            o10.Checked = obj.o10;
            o11.Checked = obj.o11;
            o12.Checked = obj.o12;
        }
    }
}
