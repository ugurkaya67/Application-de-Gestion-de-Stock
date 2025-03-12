using System;
using System.Windows.Forms;

namespace StockManagement.UI
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            var manageProductsForm = new MainForm(); // Affiche la gestion des produits
            manageProductsForm.Show();
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(); 
            addProductForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Ferme l'application
        }
    }
}
