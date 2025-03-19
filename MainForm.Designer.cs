namespace StockManagement.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;

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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 50); // Position ajustée pour laisser de l'espace à la recherche
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewProducts.TabIndex = 0;

            // Ajouter une colonne "Modifier"
            DataGridViewButtonColumn btnEditColumn = new DataGridViewButtonColumn();
            btnEditColumn.HeaderText = "Action";
            btnEditColumn.Text = "Modifier";
            btnEditColumn.Name = "btnEdit";
            btnEditColumn.UseColumnTextForButtonValue = true;
            this.dataGridViewProducts.Columns.Add(btnEditColumn);

            // Ajouter l'événement pour gérer les clics sur les boutons "Modifier"
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);


            // 
            // txtSearch (Zone de recherche)
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12); // Position juste au-dessus du dataGridView
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 23); 
            this.txtSearch.TabIndex = 1;

            // Placeholder manuel pour indiquer la recherche
            this.txtSearch.Text = "Rechercher un produit...";
            this.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText;

            this.txtSearch.GotFocus += (sender, e) => {
                if (this.txtSearch.Text == "Rechercher un produit...") {
                    this.txtSearch.Text = "";
                    this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
                }
            };

            this.txtSearch.LostFocus += (sender, e) => {
                if (string.IsNullOrWhiteSpace(this.txtSearch.Text)) {
                    this.txtSearch.Text = "Rechercher un produit...";
                    this.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText;
                }
            };

            // 
            // btnSearch (Bouton de recherche)
            // 
            this.btnSearch.Location = new System.Drawing.Point(420, 12); // Juste à droite du champ de recherche
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Name = "MainForm";
            this.Text = "Gestion de Stock";
            this.ResumeLayout(false);
            this.PerformLayout(); // Important pour que les éléments soient bien visibles
        }
    }
}
