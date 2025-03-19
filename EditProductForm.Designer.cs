namespace StockManagement.UI
{
    partial class EditProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCancel;

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
            this.txtName = new System.Windows.Forms.TextBox();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            
            this.SuspendLayout();

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);

            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(20, 60);
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(200, 23);
            this.numericPrice.DecimalPlaces = 2;
            this.numericPrice.Minimum = 0;
            this.numericPrice.Maximum = 1000;

            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(20, 100);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(200, 23);
            this.numericQuantity.Minimum = 0;
            this.numericQuantity.Maximum = 1000;

            // 
            // comboCategory
            // 
            this.comboCategory.Location = new System.Drawing.Point(20, 140);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(200, 23);
            this.comboCategory.Items.AddRange(new object[] { "Électronique", "Vêtements", "Alimentaire", "Accessoires" });
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(20, 180);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(100, 30);
            this.btnSaveChanges.Text = "Enregistrer";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(130, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Text = "Annuler";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // EditProductForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnCancel);
            this.Name = "EditProductForm";
            this.Text = "Modifier un produit";

            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
