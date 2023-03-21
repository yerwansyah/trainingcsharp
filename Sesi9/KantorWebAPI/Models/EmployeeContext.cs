using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace KantorWebAPI.Models
{
    public class EmployeeContext
    {
        public string ConnectionString { get; set; }

        public EmployeeContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<EmployeeItem> ListEmployee()
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee", connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            Id = reader.GetInt32("id"),
                            Nama = reader.GetString("nama"),
                            JenisKelamin = reader.GetString("jenis_kelamin"),
                            Alamat = reader.GetString("alamat")
                        });
                    }
                }
            }

            return list;
        }

        public EmployeeItem GetEmployee(int id)
        {
            EmployeeItem item = new EmployeeItem();

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        item.Id = reader.GetInt32("id");
                        item.Nama = reader.GetString("nama");
                        item.JenisKelamin = reader.GetString("jenis_kelamin");
                        item.Alamat = reader.GetString("alamat");
                    }
                }
            }

            return item;
        }
    }
}
