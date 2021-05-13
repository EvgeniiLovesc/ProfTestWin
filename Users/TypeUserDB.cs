using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NK_TEST.Users
{
    class TypeUserDB
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        
        
        public int id;
        public string  name;
        public string  description = "";
        public string comment = "";
        public bool perm_test_create;
        public bool perm_test_edit;
        public bool perm_test_delete;
        public bool perm_protocol_create;
        public bool perm_protocol_edit;
        public bool perm_protocol_delete;
        public bool perm_set_examiner;
        public bool perm_user_management;
        public bool m_yk;
        public bool m_pk;
        public bool m_vik;
        public bool m_pvk;
        public bool m_ek;
        public bool m_mk;
        public bool m_ae;
        public bool m_tk;
        public bool m_pvt;
        public bool m_yt;
        public bool m_vd;
        public bool auto_exam;
        public bool o1;
        public bool o2;
        public bool o3;
        public bool o4;
        public bool o5;
        public bool o6;
        public bool o7;
        public bool o8;
        public bool o9;
        public bool o10;
        public bool o11;
        public bool o12;


        public List<TypeUserDB> list_objects = new List<TypeUserDB>();
        //...

        public TypeUserDB() { }

        public TypeUserDB(int type_user_id) 
        { 
            this.id = type_user_id;

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM type_user WHERE id = " + type_user_id.ToString();
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    this.name = dataReader.GetValue(1).ToString();;
                    this.description = dataReader.GetValue(2).ToString();;
                    this.comment = dataReader.GetValue(3).ToString();;
                    this.perm_test_create = Convert.ToBoolean(dataReader.GetValue(4));
                    this.perm_test_edit = Convert.ToBoolean(dataReader.GetValue(5));
                    this.perm_test_delete = Convert.ToBoolean(dataReader.GetValue(6));
                    this.perm_protocol_create = Convert.ToBoolean(dataReader.GetValue(7));
                    this.perm_protocol_edit = Convert.ToBoolean(dataReader.GetValue(8));
                    this.perm_protocol_delete = Convert.ToBoolean(dataReader.GetValue(9));
                    this.perm_set_examiner = Convert.ToBoolean(dataReader.GetValue(10));
                    this.perm_user_management = Convert.ToBoolean(dataReader.GetValue(11));
                    this.m_yk = Convert.ToBoolean(dataReader.GetValue(12));
                    this.m_pk = Convert.ToBoolean(dataReader.GetValue(13));
                    this.m_vik = Convert.ToBoolean(dataReader.GetValue(14));
                    this.m_pvk = Convert.ToBoolean(dataReader.GetValue(15));
                    this.m_ek = Convert.ToBoolean(dataReader.GetValue(16));
                    this.m_mk = Convert.ToBoolean(dataReader.GetValue(17));
                    this.m_ae = Convert.ToBoolean(dataReader.GetValue(18));
                    this.m_tk = Convert.ToBoolean(dataReader.GetValue(19));
                    this.m_pvt = Convert.ToBoolean(dataReader.GetValue(20));
                    this.m_yt = Convert.ToBoolean(dataReader.GetValue(21));
                    this.m_vd = Convert.ToBoolean(dataReader.GetValue(22));
                    this.auto_exam = Convert.ToBoolean(dataReader.GetValue(23));
                    this.o1 = Convert.ToBoolean(dataReader.GetValue(24));
                    this.o2 = Convert.ToBoolean(dataReader.GetValue(25));
                    this.o3 = Convert.ToBoolean(dataReader.GetValue(26));
                    this.o4 = Convert.ToBoolean(dataReader.GetValue(27));
                    this.o5 = Convert.ToBoolean(dataReader.GetValue(28));
                    this.o6 = Convert.ToBoolean(dataReader.GetValue(29));
                    this.o7 = Convert.ToBoolean(dataReader.GetValue(30));
                    this.o8 = Convert.ToBoolean(dataReader.GetValue(31));
                    this.o9 = Convert.ToBoolean(dataReader.GetValue(32));
                    this.o10 = Convert.ToBoolean(dataReader.GetValue(33));
                    this.o11 = Convert.ToBoolean(dataReader.GetValue(34));
                    this.o12 = Convert.ToBoolean(dataReader.GetValue(35));

                }
                connection.Close();
            }
            catch (Exception ex) { }          
        }

        public void Fill() 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM type_user";
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    TypeUserDB obj = new TypeUserDB();
                    obj.id = Convert.ToInt32(dataReader.GetValue(0));
                    obj.name = Convert.ToString(dataReader.GetValue(1));
                    obj.description = Convert.ToString(dataReader.GetValue(2));
                    obj.comment = Convert.ToString(dataReader.GetValue(3));
                    obj.perm_test_create = Convert.ToBoolean(dataReader.GetValue(4));
                    obj.perm_test_edit = Convert.ToBoolean(dataReader.GetValue(5));
                    obj.perm_test_delete = Convert.ToBoolean(dataReader.GetValue(6));
                    obj.perm_protocol_create = Convert.ToBoolean(dataReader.GetValue(7));
                    obj.perm_protocol_edit = Convert.ToBoolean(dataReader.GetValue(8));
                    obj.perm_protocol_delete = Convert.ToBoolean(dataReader.GetValue(9));
                    obj.perm_set_examiner = Convert.ToBoolean(dataReader.GetValue(10));
                    obj.perm_user_management = Convert.ToBoolean(dataReader.GetValue(11));
                    obj.m_yk = Convert.ToBoolean(dataReader.GetValue(12));
                    obj.m_pk = Convert.ToBoolean(dataReader.GetValue(13));
                    obj.m_vik = Convert.ToBoolean(dataReader.GetValue(14));
                    obj.m_pvk = Convert.ToBoolean(dataReader.GetValue(15));
                    obj.m_ek = Convert.ToBoolean(dataReader.GetValue(16));
                    obj.m_mk = Convert.ToBoolean(dataReader.GetValue(17));
                    obj.m_ae = Convert.ToBoolean(dataReader.GetValue(18));
                    obj.m_tk = Convert.ToBoolean(dataReader.GetValue(19));
                    obj.m_pvt = Convert.ToBoolean(dataReader.GetValue(20)); 
                    obj.m_yt = Convert.ToBoolean(dataReader.GetValue(21));
                    obj.m_vd = Convert.ToBoolean(dataReader.GetValue(22));
                    obj.auto_exam = Convert.ToBoolean(dataReader.GetValue(23));
                    obj.o1 = Convert.ToBoolean(dataReader.GetValue(24));
                    obj.o2 = Convert.ToBoolean(dataReader.GetValue(25));
                    obj.o3 = Convert.ToBoolean(dataReader.GetValue(26));
                    obj.o4 = Convert.ToBoolean(dataReader.GetValue(27));
                    obj.o5 = Convert.ToBoolean(dataReader.GetValue(28));  
                    obj.o6 = Convert.ToBoolean(dataReader.GetValue(29));
                    obj.o7 = Convert.ToBoolean(dataReader.GetValue(30));
                    obj.o8 = Convert.ToBoolean(dataReader.GetValue(31));
                    obj.o9 = Convert.ToBoolean(dataReader.GetValue(32));
                    obj.o10 = Convert.ToBoolean(dataReader.GetValue(33));
                    obj.o11 = Convert.ToBoolean(dataReader.GetValue(34));
                    obj.o12 = Convert.ToBoolean(dataReader.GetValue(34));

                    list_objects.Add(obj);
                    obj = null;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
            }
        }
    
        public void AddToDB(string name) 
        {
            this.name = name;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {

                string sql2 = "INSERT INTO type_user(name, perm_test_create, perm_test_edit, perm_test_delete, perm_protocol_create, perm_protocol_edit, perm_protocol_delete, perm_set_examiner, perm_user_management, m_yk, m_pk, m_vik, m_pvk, m_ek, m_mk, m_ae, m_tk, m_pvt, " +
                "m_yt, m_vd, auto_exam, o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12) VALUES('" + this.name + "', " +
                "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);";

                SqlCommand command = new SqlCommand(sql2, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }    
    
        public void Delete(int id) 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                
                string sql = "DELETE FROM type_user WHERE id = '" + id.ToString() +  "';";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        
        }

        public void Save() 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                 string sql = "UPDATE type_user SET " + 
                    "name = '" + this.name + 
                    "', description = '" + this.description.ToString() + 
                    "', comment = '" + this.comment.ToString() + 
                    "', perm_test_create = " + Convert.ToInt32(this.perm_test_create).ToString() + 
                    ", perm_test_edit = " + Convert.ToInt32(this.perm_test_edit).ToString() + 
                    ", perm_test_delete = " + Convert.ToInt32(this.perm_test_delete).ToString() + 
                    ", perm_protocol_create = " + Convert.ToInt32(this.perm_protocol_create).ToString() + 
                    ", perm_protocol_edit = " + Convert.ToInt32(this.perm_protocol_edit).ToString() +
                    ", perm_protocol_delete = " + Convert.ToInt32(this.perm_protocol_delete).ToString() +
                    ", perm_set_examiner = " + Convert.ToInt32(this.perm_set_examiner).ToString() +
                    ", perm_user_management = " + Convert.ToInt32(this.perm_user_management).ToString() +
                    ", m_yk = " + Convert.ToInt32(this.m_yk).ToString() +
                    ", m_pk = " + Convert.ToInt32(this.m_pk).ToString() +
                    ", m_vik = " + Convert.ToInt32(this.m_vik).ToString() +
                    ", m_pvk = " + Convert.ToInt32(this.m_pvk).ToString() +
                    ", m_ek = " + Convert.ToInt32(this.m_ek).ToString() +
                    ", m_mk = " + Convert.ToInt32(this.m_mk).ToString() +
                    ", m_ae = " + Convert.ToInt32(this.m_ae).ToString() +
                    ", m_tk = " + Convert.ToInt32(this.m_tk).ToString() +
                    ", m_pvt = " + Convert.ToInt32(this.m_pvt).ToString() +
                    ", m_yt = " + Convert.ToInt32(this.m_yt).ToString() +
                    ", m_vd = " + Convert.ToInt32(this.m_vd).ToString() +
                    ", auto_exam = " + Convert.ToInt32(this.auto_exam).ToString() +
                    ", o1 = " + Convert.ToInt32(this.o1).ToString() +
                    ", o2 = " + Convert.ToInt32(this.o2).ToString() +
                    ", o3 = " + Convert.ToInt32(this.o3).ToString() +
                    ", o4 = " + Convert.ToInt32(this.o4).ToString() +
                    ", o5 = " + Convert.ToInt32(this.o5).ToString() +
                    ", o6 = " + Convert.ToInt32(this.o6).ToString() +
                    ", o7 = " + Convert.ToInt32(this.o7).ToString() +
                    ", o8 = " + Convert.ToInt32(this.o8).ToString() +
                    ", o9 = " + Convert.ToInt32(this.o9).ToString() +
                    ", o10 = " + Convert.ToInt32(this.o10).ToString() +
                    ", o11 = " + Convert.ToInt32(this.o11).ToString() +
                    ", o12 = " + Convert.ToInt32(this.o12).ToString() +
                    " WHERE id = " + this.id.ToString();

                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        
        }

    }


}
