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
                var products = db.GetProducts();

                // Vider les colonnes pour éviter les doublons
                dataGridViewProducts.Columns.Clear();

                // Ajouter les colonnes principales
                dataGridViewProducts.DataSource = products;

                // Ajouter la colonne Modifier si elle n'existe pas
                if (!dataGridViewProducts.Columns.Contains("btnEdit"))
                {
                    DataGridViewButtonColumn btnEditColumn = new DataGridViewButtonColumn
                    {
                        HeaderText = "Action",
                        Text = "Modifier",
                        Name = "btnEdit",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridViewProducts.Columns.Add(btnEditColumn);
                }
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
            // Vérifie si la colonne cliquée est bien la colonne "Modifier"
            if (e.ColumnIndex == dataGridViewProducts.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                try
                {
                    // Vérifier que toutes les données requises sont présentes
                    if (dataGridViewProducts.Rows[e.RowIndex].Cells["Id"].Value == null)
                    {
                        MessageBox.Show("L'ID du produit est introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int productId = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells["Id"].Value);
                    string productName = dataGridViewProducts.Rows[e.RowIndex].Cells["Nom"].Value?.ToString() ?? string.Empty;
                    decimal productPrice = Convert.ToDecimal(dataGridViewProducts.Rows[e.RowIndex].Cells["Prix"].Value ?? 0);
                    int productQuantity = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells["Quantite"].Value ?? 0);
                    string productCategory = dataGridViewProducts.Rows[e.RowIndex].Cells["Categorie"].Value?.ToString() ?? string.Empty;

                    // Vérifier si les données sont valides avant de poursuivre
                    if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(productCategory))
                    {
                        MessageBox.Show("Données invalides pour ce produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Ouvre le formulaire de modification
                    var editForm = new EditProductForm(productId, productName, productPrice, productQuantity, productCategory);
                    editForm.ShowDialog();

                    // Recharge les produits après la mise à jour
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la gestion du clic : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
