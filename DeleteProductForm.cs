using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace StockManagement.UI
{
    public partial class DeleteProductForm : Form
    {
        private Database db;

        public DeleteProductForm()
        {
            InitializeComponent();
            db = new Database(); // Instance de la classe Database pour gérer les interactions avec MySQL
        }

        // Bouton "Supprimer"
        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtProductId.Text.Trim(), out int productId))
            {
                db.DeleteProduct(productId);
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez entrer un ID valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Bouton "Annuler"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Ferme simplement le formulaire
        }
    }
}
