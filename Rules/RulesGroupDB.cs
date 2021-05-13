using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NK_TEST.Rules
{
    class RulesGroupDB
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;

        public int id;
        public string name;
        public string description;
        public string comment;
        public string date_created;
        public int owner_id;

        public List<RulesGroupDB> list_objects = new List<RulesGroupDB>();

        public RulesGroupDB() { }


        public void Fill() 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataReader dataReader;
                string sql = "SELECT * FROM rules_group";
                SqlCommand command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    RulesGroupDB obj = new RulesGroupDB();
                    obj.id = Convert.ToInt32(dataReader.GetValue(0));
                    obj.name = Convert.ToString(dataReader.GetValue(1));
                    obj.description = Convert.ToString(dataReader.GetValue(2));
                    obj.comment = Convert.ToString(dataReader.GetValue(3));
                    obj.date_created = Convert.ToString(dataReader.GetValue(4));
                    obj.owner_id = Convert.ToInt32(dataReader.GetValue(5));

                    list_objects.Add(obj);
                    obj = null;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
            }
        }

        public void AddToDB() 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {                
                string sql = "INSERT INTO rules_group(" +
                    "name, description, comment, date_created, owner_id)  VALUES('"
                    + this.name + "', '"
                    + this.description + "', '"
                    + this.comment + "', '"
                    + this.date_created + "', '" 
                    + this.owner_id
                    + "');";

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

        public void Delete(int id) 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                
                string sql = "DELETE FROM rules_group WHERE id = '" + id.ToString() +  "';";
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
