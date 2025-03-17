using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace StockManagement.UI
{
    public partial class AddProductForm : Form
    {
        private Database db;

        public AddProductForm()
        {
            InitializeComponent();
            db = new Database(); // Instance de la classe Database pour gérer les interactions avec MySQL
        }

        // Bouton "Ajouter"
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string productName = txtName.Text.Trim();
            decimal productPrice = numericPrice.Value;
            int productQuantity = (int)numericQuantity.Value;
            string productCategory = comboCategory.SelectedItem?.ToString();

            // Vérification des champs obligatoires
            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(productCategory))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ajout à la base de données
            try
            {
                string query = @"INSERT INTO Products (Nom, Prix, Quantite, Categorie) 
                                 VALUES (@Nom, @Prix, @Quantite, @Categorie)";

                using (var connection = db.GetConnection())
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", productName ?? string.Empty);
                        cmd.Parameters.AddWithValue("@Prix", productPrice);
                        cmd.Parameters.AddWithValue("@Quantite", productQuantity);
                        cmd.Parameters.AddWithValue("@Categorie", productCategory);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Produit ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Ferme le formulaire après succès
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de l'ajout du produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du produit : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bouton "Annuler"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Ferme simplement le formulaire
        }
    }
}
