namespace StockManagement.UI
{
    partial class AddProductForm
    {
        private System.ComponentModel.IContainer components = null;

        // Déclaration des contrôles
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCategory;
        // Dispose pour libérer les ressources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Initialisation des composants
        private void InitializeComponent()
        {
            this.txtName = new TextBox();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();

            // Form Configuration
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Text = "Ajouter un produit";

            // --- Nom du Produit ---
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.Text = "Nom du produit :";

            this.txtName.Location = new System.Drawing.Point(150, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 23);

            // --- Prix ---
            this.lblPrice.Location = new System.Drawing.Point(20, 60);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 23);
            this.lblPrice.Text = "Prix :";

            this.numericPrice.Location = new System.Drawing.Point(150, 60);
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(150, 23);
            this.numericPrice.DecimalPlaces = 2;
            this.numericPrice.Minimum = 0;

            // --- Quantité ---
            this.lblQuantity.Location = new System.Drawing.Point(20, 100);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 23);
            this.lblQuantity.Text = "Quantité :";

            this.numericQuantity.Location = new System.Drawing.Point(150, 100);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(150, 23);
            this.numericQuantity.Minimum = 0;

            // --- Catégorie ---
            this.lblCategory.Location = new System.Drawing.Point(20, 140);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 23);
            this.lblCategory.Text = "Catégorie :";

            this.comboCategory.Location = new System.Drawing.Point(150, 140);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(150, 23);
            this.comboCategory.Items.AddRange(new object[]
            {
                "Électronique",
                "Vêtements",
                "Alimentaire",
                "Accessoires"
            });
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // --- Bouton Ajouter ---
            this.btnAddProduct.Location = new System.Drawing.Point(20, 200);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 30);
            this.btnAddProduct.Text = "Ajouter";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);

            // --- Bouton Annuler ---
            this.btnCancel.Location = new System.Drawing.Point(200, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Text = "Annuler";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Ajout des composants au formulaire
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblCategory);

            this.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
        }

    }
}