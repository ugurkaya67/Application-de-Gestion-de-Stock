using System;
using System.Windows.Forms;

namespace StockManagement.UI
{
    public partial class EditProductForm : Form
    {
        private readonly int productId;
        private Database db;

        public EditProductForm(int id, string name, decimal price, int quantity, string category)
        {
            InitializeComponent();
            db = new Database();

            // Remplir les champs avec les infos actuelles
            productId = id;
            Console.WriteLine($"ID du produit à modifier : {productId}");
            txtName.Text = name;
            numericPrice.Value = price;
            numericQuantity.Value = quantity;
            comboCategory.SelectedItem = category;
        }

        // Mise à jour du produit
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string newName = txtName.Text.Trim();
            decimal newPrice = numericPrice.Value;
            int newQuantity = (int)numericQuantity.Value;
            string newCategory = comboCategory.SelectedItem?.ToString() ?? string.Empty;

            // Vérification des champs vides
            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newCategory))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            db.UpdateProduct(productId, newName, newPrice, newQuantity, newCategory);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
