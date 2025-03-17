using System;
using System.Windows.Forms;
using System.Data;


namespace StockManagement.UI
{
    public partial class MainForm : Form
    {
        private Database db;

        public MainForm()
        {
            InitializeComponent();
            db = new Database();
            LoadProducts();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            db.TestConnection();
        }

        private void LoadProducts()
        {
            try
            {
                dataGridViewProducts.DataSource = db.GetProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des produits : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            LoadProducts(); 
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var deleteProductForm = new DeleteProductForm();
            deleteProductForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Veuillez saisir un terme de recherche.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupère les produits correspondants
            DataTable filteredProducts = db.SearchProducts(searchTerm);

            if (filteredProducts.Rows.Count > 0)
            {
                dataGridViewProducts.DataSource = filteredProducts;
            }
            else
            {
                MessageBox.Show("Aucun produit correspondant trouvé.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
