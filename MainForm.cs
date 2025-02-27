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

        private void LoadProducts()
        {
            dataGridViewProducts.DataSource = db.GetProducts();
        }
    }
}
