using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace NK_TEST.Results
{
    class ResultsDB
    {
        public List<ResultDB> objects;
        public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public int number;

        public void Fill()
        {

            
            List<ResultDB> list_objects = new List<ResultDB>();  
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM result";
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                this.number = 0;
                while (dataReader.Read())
                {
                    ResultDB obj = new ResultDB();
                    obj.id = Convert.ToInt32(dataReader.GetValue(0));
                    obj.user_id = Convert.ToInt32(dataReader.GetValue(1));
                    obj.test_id = Convert.ToInt32(dataReader.GetValue(2));
                    obj.date = Convert.ToString(dataReader.GetValue(3)); 
                    obj.time = Convert.ToString(dataReader.GetValue(4));
                    obj.status = Convert.ToString(dataReader.GetValue(5));
                    obj.value = Convert.ToInt32(dataReader.GetValue(6));
                    obj.result = Convert.ToString(dataReader.GetValue(7));
                  
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
