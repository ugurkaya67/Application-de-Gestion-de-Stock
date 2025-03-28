using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StockManagement.UI
{
    public class Database
    {
        private readonly string connectionString = "Server=localhost;Database=StockDB;User ID=root;Password=root;Port=3306;";

        public void TestConnection()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Connexion réussie à la base de données !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
        public DataTable GetProducts()
        {
            DataTable products = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Products"; // Assurez-vous que la table `Products` existe bien
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(products);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des produits : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return products;
        }
        public void AddProduct(string name, decimal price, int quantity, string category)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Products (name, price, quantity, category) VALUES (@name, @price, @quantity, @category)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@category", category);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produit ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du produit : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteProduct(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Products where id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produit supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression du produit : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public DataTable SearchProducts(string searchTerm)
        {
            DataTable products = new DataTable();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Products WHERE Nom LIKE @search OR Categorie LIKE @search";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(products);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche de produits : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return products;
        }
        public void UpdateProduct(int id, string name, decimal price, int quantity, string category)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Vérification si le produit existe avant de le mettre à jour
                    string checkQuery = "SELECT COUNT(*) FROM Products WHERE Id = @id";
                    using (var checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", id);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count == 0)
                        {
                            MessageBox.Show("Aucun produit trouvé avec cet ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Mise à jour du produit
                    string updateQuery = @"
                        UPDATE Products 
                        SET Nom = @name, Prix = @price, Quantite = @quantity, Categorie = @category, DateAjout = NOW()
                        WHERE Id = @id";

                    using (var cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@category", category);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produit mis à jour avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour du produit : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
