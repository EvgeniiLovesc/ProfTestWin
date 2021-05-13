using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace NK_TEST.admins
{
    class AdminsDB
    {
        public List<AdminDB> objects;
        public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public int number;

        public AdminsDB() 
        {
        }   

        public void Fill()
        {
            List<AdminDB> list_objects = new List<AdminDB>();  
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM admins";
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                this.number = 0;
                while (dataReader.Read())
                {
                    AdminDB obj = new AdminDB();
                    obj.id = Convert.ToInt32(dataReader.GetValue(0));
                    obj.name = Convert.ToString(dataReader.GetValue(1));
                    obj.last_name = Convert.ToString(dataReader.GetValue(2));
                    obj.middle_name = Convert.ToString(dataReader.GetValue(3));
                    obj.register_time = Convert.ToString(dataReader.GetValue(4));
                    obj.comment = Convert.ToString(dataReader.GetValue(5));
                    obj.type_user = Convert.ToInt32(dataReader.GetValue(6));
                    obj.login = Convert.ToString(dataReader.GetValue(7));                    
                    obj.password = Convert.ToString(dataReader.GetValue(8));

                    list_objects.Add(obj);
                    this.number += 1;
                    obj = null;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                this.number = 0;
            }

            objects = list_objects;            
        }
    }
}
