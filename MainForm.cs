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
        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifie si l'utilisateur a cliqué sur la colonne "Modifier"
            if (e.ColumnIndex == dataGridViewProducts.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                // Récupère les informations du produit sélectionné
                int productId = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells["Id"].Value);
                string productName = dataGridViewProducts.Rows[e.RowIndex].Cells["Nom"].Value.ToString();
                decimal productPrice = Convert.ToDecimal(dataGridViewProducts.Rows[e.RowIndex].Cells["Prix"].Value);
                int productQuantity = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells["Quantite"].Value);
                string productCategory = dataGridViewProducts.Rows[e.RowIndex].Cells["Categorie"].Value.ToString();

                // Ouvre le formulaire d'édition avec les informations du produit
                EditProductForm editForm = new EditProductForm(productId, productName, productPrice, productQuantity, productCategory);
                editForm.ShowDialog();

                // Recharge les produits après modification
                LoadProducts();
            }
        }
    }
}
