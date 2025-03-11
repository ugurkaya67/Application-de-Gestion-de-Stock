using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StockManagement
{
    public static class DatabaseHelper
    {
        private static string connectionString = System.Configuration.ConfigurationManager
            .ConnectionStrings["MySqlConnection"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static void TestConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    MessageBox.Show("Connexion réussie à la base de données !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }
    }
}
