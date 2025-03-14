namespace StockManagement.UI
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnManageProducts
            // 
            this.btnManageProducts.Location = new System.Drawing.Point(50, 30);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(200, 40);
            this.btnManageProducts.Text = "Gérer les Produits";
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);

            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(50, 80);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 40);
            this.btnExit.Text = "Quitter";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // btnAddProduct
            // 
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnAddProduct.Location = new System.Drawing.Point(50, 130); // Position
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(200, 40);
            this.btnAddProduct.Text = "Ajouter Produit";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            
            //
            // btnDeleteProduct
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct.Location = new System.Drawing.Point(50, 180); // Position
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteProduct.Text = "Supprimer Produit";
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);

            // 
            // MainMenuForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btnManageProducts);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnDeleteProduct);            
            this.Controls.Add(this.btnExit);
            this.Name = "MainMenuForm";
            this.Text = "Menu Principal";

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnExit;
    }
}
