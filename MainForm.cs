using System;
using System.Windows.Forms;

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

    }
}
