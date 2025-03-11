namespace StockManagement.UI
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

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
            // MainMenuForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btnManageProducts);
            this.Controls.Add(this.btnExit);
            this.Name = "MainMenuForm";
            this.Text = "Menu Principal";

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnExit;
    }
}
