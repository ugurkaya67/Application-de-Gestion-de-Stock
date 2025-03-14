namespace StockManagement.UI
{
    partial class DeleteProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnConfirmDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblProductId;

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
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btnConfirmDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblProductId = new System.Windows.Forms.Label();

            // Label "ID du Produit"
            this.lblProductId.Location = new System.Drawing.Point(20, 20);
            this.lblProductId.Text = "ID du produit :";
            this.Controls.Add(this.lblProductId);

            // TextBox "ID du Produit"
            this.txtProductId.Location = new System.Drawing.Point(150, 20);
            this.Controls.Add(this.txtProductId);

            // Bouton "Supprimer"
            this.btnConfirmDelete.Location = new System.Drawing.Point(20, 60);
            this.btnConfirmDelete.Text = "Supprimer";
            this.btnConfirmDelete.Click += new System.EventHandler(this.btnConfirmDelete_Click);
            this.Controls.Add(this.btnConfirmDelete);

            // Bouton "Annuler"
            this.btnCancel.Location = new System.Drawing.Point(150, 60);
            this.btnCancel.Text = "Annuler";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.Controls.Add(this.btnCancel);

            // Form Configuration
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Text = "Supprimer un produit";
        }
    }
}