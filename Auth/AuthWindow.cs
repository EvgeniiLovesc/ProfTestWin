using NK_TEST.admins;
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


    public partial class AuthWindow : Form
    {

        public int list_counter = 0;


        public AuthWindow(bool status_connection)
        {
            InitializeComponent();

            listStatus.Scrollable = true;
            listStatus.View = View.Details;
            //listStatus.View = View.List;
            ColumnHeader header = new ColumnHeader();
            // Добавим фиктивный столбец чтобы строки распологались в столбик
            header.Text = "";
            header.Name = "col1";
            header.Width = 380;
            listStatus.Columns.Add(header);
            listStatus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;


            ListViewItem li = new ListViewItem();
            if (status_connection)
            {
                li.ForeColor = Color.Green;
                li.Text = "[" + list_counter + "]: Соединение с базой данных установлено.";
                listStatus.Items.Add(li);
                this.list_counter++;
                listStatus.Items.Add("[" + list_counter +  "]: Запрос авторизации: введите логин и пароль");
                listStatus.GridLines = true;
            }
            else 
            {
                li.ForeColor = Color.Red;
                li.Text = "[" + list_counter + "]: Ошибка соединения с базой данных.";
                listStatus.Items.Add(li);
            }
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            //AdminDB authorize_user = new AdminDB(tbLogin.Text);
            //if (authorize_user.AuthCheck(tbPassword.Text))
            //{
                // Обновим имя авторизованного администратора
                MainForm main_fm = (MainForm)Application.OpenForms["MainForm"];
                main_fm.showApp();
                main_fm.UpdateAdmin(tbLogin.Text);
                main_fm.login = "admin"; //tbLogin.Text;
                main_fm.setAuthAdmin("admin");
                this.Close();
            //}
            //else 
            //{
            //    ListViewItem li = new ListViewItem();
            //    this.list_counter++;
            //    li.ForeColor = Color.Red;
            //    li.Text = "[" + list_counter + "]: Логин или пароль неверны.";
            //    listStatus.Items.Add(li);
            //    listStatus.Items[listStatus.Items.Count - 1].EnsureVisible();
            //}

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
