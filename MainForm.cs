using NK_TEST.admins;
using NK_TEST.Admins;
using NK_TEST.Rules;
using NK_TEST.Tests;
using NK_TEST.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NK_TEST
{
    public partial class MainForm : Form
    {

        DataDB objDB;
        public string login;
        string password;
        
        public MainForm()
        {
            InitializeComponent();

            tabControl.Hide();
            this.BackColor = ColorTranslator.FromHtml("#C8C9D0");
            objDB = new DataDB();
            // Заполним DataGrid
            objDB.dgvTests = this.dataGridTests;
            objDB.dgvUsers = this.dataGridUsers;
            objDB.dgvRules = this.dataGridRules;
            objDB.dgvAdmins = this.dataGridAdmins;
            objDB.dgvResults = this.dataGridResults;
            objDB.statusConnection = this.lblStatusConnection;
            objDB.serverStatus = this.lblServerStatus;
            objDB.pbStatus = this.pbStatusConnection;
            objDB.FillTests();

            //Окно авторизации
            AuthWindow aw = new AuthWindow(objDB.status);
            aw.Show();
            aw.BringToFront();
            aw.TopMost = true;

        }

        public void showApp() 
        {
            this.tabControl.Show();
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Text =="О программе")
            {
                MessageBox.Show("О программе");
            }
            else
            { 
                MessageBox.Show("О другой программе");
            }

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabAbout_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void tabControl_Click_1(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Text =="О программе")
            {
                About ab = new About();
                ab.tabControl = this.tabControl; 
                ab.Show();
            }
        }

        private void tabTests_Click(object sender, EventArgs e)
        {

        }

        private void tabAbout_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Получим id выбранного теста
            int selectedrowindex = dataGridTests.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridTests.Rows[selectedrowindex];
            int selected_id = Convert.ToInt32(selectedRow.Cells["id_test"].Value); 
            
            EditTest ete = new EditTest(selected_id);
            ete.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabServer_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button85_Click(object sender, EventArgs e)
        {

        }

        private void button90_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser user_window = new AddUser();
            user_window.Show();
        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridUsers.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridUsers.Rows[selectedrowindex];
            int selected_id = Convert.ToInt32(selectedRow.Cells["user_id"].Value);            
          
            EditUser user_window = new EditUser(selected_id);
            user_window.Show();
        }

        private void btnAddUserGroup_Click(object sender, EventArgs e)
        {
            AddTestGroup user_window = new AddTestGroup();
            user_window.Show();
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить пользователя?", "Вопрос", MessageBoxButtons.YesNo);
            switch(dr)
            {
                case DialogResult.Yes:
                    int selectedrowindex = dataGridUsers.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridUsers.Rows[selectedrowindex];
                    int selected_id = Convert.ToInt32(selectedRow.Cells["user_id"].Value);
                    UserDB obj = new UserDB();
                    obj.Delete(selected_id);
                    UpdateDGV_Users();
                    obj = null;
                    break;
                case DialogResult.No:

                  break;
            }
        }

        private void btnUserStatistic_Click(object sender, EventArgs e)
        {
            UserPrintDialog up = new UserPrintDialog();
            up.Show();
        }

        private void btnUserLog_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridUsers.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridUsers.Rows[selectedrowindex];
            int selected_id = Convert.ToInt32(selectedRow.Cells["user_id"].Value);

            UserLog ul = new UserLog(selected_id);
            ul.Show();
        }

        private void btnUserEmail_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridUsers.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridUsers.Rows[selectedrowindex];
            int user_id = Convert.ToInt32(selectedRow.Cells["user_id"].Value);
            UserDB user = new UserDB(user_id);
            if (user.email != null)
            {
                System.Diagnostics.Process.Start("mailto:" + user.email);
            }
            else 
            {
                MessageBox.Show("У пользователя не указан Email");
            }

        }

        private void btnUserImport_Click(object sender, EventArgs e)
        {
            ImportUser iu = new ImportUser();
                iu.Show();
        }

        private void btnUserExport_Click(object sender, EventArgs e)
        {
            ExportUser eu = new ExportUser();
            eu.Show();
        }

        private void btnUserSearch_Click(object sender, EventArgs e)
        {
            FindUser fu = new FindUser();
            fu.Show();
        }

        private void btnRulesAdd_Click(object sender, EventArgs e)
        {
            AddRules ar = new AddRules();
            ar.Show();
        }

        private void btnRulesEdit_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridRules.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridRules.Rows[selectedrowindex];
            int id_rules = Convert.ToInt32(selectedRow.Cells["id_rules"].Value);             
             
            EditRules er = new EditRules(id_rules);
            er.Show();
        }

        private void btnRulesDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить правило?", "Вопрос", MessageBoxButtons.YesNo);
            switch(dr)
            {
                case DialogResult.Yes:
                    int selectedrowindex = dataGridRules.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridRules.Rows[selectedrowindex];
                    int selected_id = Convert.ToInt32(selectedRow.Cells["id_rules"].Value);
                    RuleDB obj = new RuleDB();
                    obj.Delete(selected_id);
                    UpdateDGV_Rules();
                    obj = null;
                    break;
                case DialogResult.No:

                  break;
            }
        }

        private void btnRulesGroup_Click(object sender, EventArgs e)
        {
            AddRulesGroup rg = new AddRulesGroup();
            rg.Show();
        }

        public void setAuthAdmin(string name)
        {
            lblAuthAdmin.Text = name;
        }

        private void btnRulesSearch_Click(object sender, EventArgs e)
        {
            FindRules fr = new FindRules();
            fr.Show();
        }

        private void btnRulesStatistics_Click(object sender, EventArgs e)
        {
            ResultOnRulesPrintDialog rpd = new ResultOnRulesPrintDialog();
            rpd.Show();
        }

        private void btnTestDoc_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Print(1);

        }

        private void btnServerSettings_Click(object sender, EventArgs e)
        {
            Settings st = new Settings();
            st.Show();
        }

        private void btnServerLog_Click(object sender, EventArgs e)
        {
            MainLog ml = new MainLog();
            ml.Show();
        }

        private void btnServerInfo_Click(object sender, EventArgs e)
        {
            AllInformation alli = new AllInformation();
            alli.Show();
        }

        private void btnNewTest_Click(object sender, EventArgs e)
        {
            AddTest at = new AddTest();
            at.Show();
        }

        private void addGroup_Click(object sender, EventArgs e)
        {
            AddTestGroup atg = new AddTestGroup();
            atg.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить тест?", "Вопрос", MessageBoxButtons.YesNo);
            switch(dr)
            {
               case DialogResult.Yes:
                    int selectedrowindex = dataGridTests.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridTests.Rows[selectedrowindex];
                    int selected_id = Convert.ToInt32(selectedRow.Cells["id_test"].Value);
                    TestDB obj = new TestDB();
                    obj.Delete(selected_id);
                    UpdateDGV_Tests();
                    obj = null;
                    break;
               case DialogResult.No:
                  break;
            }
        }

        private void btnCopyTest_Click(object sender, EventArgs e)
        {
            CopyTest ct = new CopyTest();
            ct.Show();
        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            SetPassword sp = new SetPassword();
            sp.Show();
        }

        private void btnSaveInFile_Click(object sender, EventArgs e)
        {
            SaveToFile stf = new SaveToFile();
            stf.Show();
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            this.openFileDialogTests = new System.Windows.Forms.OpenFileDialog
            {
                DefaultExt = "txt",
                Title = "Выберите файл в формате .txt для импорта тестов",
                Filter = "txt files (*.txt)|*.txt"
            };

            openFileDialogTests.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindTest ft = new FindTest();
            ft.Show();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridTests.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridTests.Rows[selectedrowindex];
            int selected_id = Convert.ToInt32(selectedRow.Cells["id_test"].Value);            
            MovingTest mt = new MovingTest(selected_id);
            mt.Show();            
        }

        private void btnTestStatistic_Click(object sender, EventArgs e)
        {
            TestLog tl = new TestLog();
            tl.Show();
        }

        private void dataGridUsers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пароль успешно изменён!");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddAdmin_Click(object sender, EventArgs e)
        {
            AddAdmin aa = new AddAdmin();
            aa.Show();
        }

        public void UpdateDGV_Admins()
        {
            objDB.FillDGVAdmins();
            dataGridAdmins.Refresh();
        }

        public void UpdateDGV_Users()
        {
            objDB.FillDGVUsers();
            dataGridUsers.Refresh();
        }

        public void UpdateDGV_Rules()
        {
            objDB.FillDGVRules();
            dataGridRules.Refresh();
        }

        public void UpdateDGV_Tests()
        {
            objDB.FillDGVTest();
            dataGridTests.Refresh();
        }

        public void UpdateAdmin(string admin_name) 
        {
            lblAuthAdmin.Text = admin_name;
        }

        public string getAdminName() 
        {
            return lblAuthAdmin.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить объект?", "Вопрос", MessageBoxButtons.YesNo);
            switch(dr)
            {
                case DialogResult.Yes:
                    int selectedrowindex = dataGridAdmins.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridAdmins.Rows[selectedrowindex];
                    int selected_id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    AdminDB obj = new AdminDB();
                    obj.Delete(selected_id);
                    UpdateDGV_Admins();
                    obj = null;
                    break;
                case DialogResult.No:

                  break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridAdmins.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridAdmins.Rows[selectedrowindex];
            int selected_id = Convert.ToInt32(selectedRow.Cells["id"].Value);            
            EditAdmin ea = new EditAdmin(selected_id);
            ea.Show();
        }

        private void btnSrvAdmin_Click(object sender, EventArgs e)
        {
            UserTypes utw = new UserTypes(0);
            utw.Show();
        }

        private void btnUserStatistic_Click_1(object sender, EventArgs e)
        {
            DeleteUserGroup dug = new DeleteUserGroup();
            dug.Show();
        }

        private void btnUserAddGroup_Click(object sender, EventArgs e)
        {
            AddUserGroup obj = new AddUserGroup();
            obj.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DeleteRulesGroup drg = new DeleteRulesGroup();
            drg.Show();
        }

        private void dataGridRules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridRules.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridRules.Rows[selectedrowindex];
            int id_rules = Convert.ToInt32(selectedRow.Cells["id_rules"].Value);             
             
            EditRules er = new EditRules(id_rules);
            er.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteTestsGroup drg = new DeleteTestsGroup();
            drg.Show();
        }
    }
}
