using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace StockManagement.UI
{
    public class Database
    {
        private MySqlConnection connection;

        public Database()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            connection = new MySqlConnection(connectionString);
        }

        public DataTable GetProducts()
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                string query = "SELECT * FROM products";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }
    }
}
