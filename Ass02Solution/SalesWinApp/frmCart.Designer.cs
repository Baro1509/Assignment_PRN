namespace SalesWinApp {
    partial class frmCart {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbCategoryId = new System.Windows.Forms.Label();
            this.lbProductId = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lbUnitInStock = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitInStock = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lbWeight = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 208);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(774, 222);
            this.dgvProducts.TabIndex = 0;
            // 
            // lbProductName
            // 
            this.lbProductName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductName.Location = new System.Drawing.Point(-1, 100);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(138, 28);
            this.lbProductName.TabIndex = 22;
            this.lbProductName.Text = "Product Name";
            // 
            // lbCategoryId
            // 
            this.lbCategoryId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCategoryId.AutoSize = true;
            this.lbCategoryId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCategoryId.Location = new System.Drawing.Point(-1, 67);
            this.lbCategoryId.Name = "lbCategoryId";
            this.lbCategoryId.Size = new System.Drawing.Size(116, 28);
            this.lbCategoryId.TabIndex = 18;
            this.lbCategoryId.Text = "Category ID";
            // 
            // lbProductId
            // 
            this.lbProductId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbProductId.AutoSize = true;
            this.lbProductId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductId.Location = new System.Drawing.Point(-1, 34);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(105, 28);
            this.lbProductId.TabIndex = 17;
            this.lbProductId.Text = "Product ID";
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.Location = new System.Drawing.Point(145, 101);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(251, 27);
            this.txtProductName.TabIndex = 25;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoryId.Location = new System.Drawing.Point(145, 68);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(251, 27);
            this.txtCategoryId.TabIndex = 24;
            // 
            // txtProductId
            // 
            this.txtProductId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductId.Location = new System.Drawing.Point(145, 35);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(251, 27);
            this.txtProductId.TabIndex = 23;
            // 
            // lbUnitInStock
            // 
            this.lbUnitInStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUnitInStock.AutoSize = true;
            this.lbUnitInStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUnitInStock.Location = new System.Drawing.Point(403, 100);
            this.lbUnitInStock.Name = "lbUnitInStock";
            this.lbUnitInStock.Size = new System.Drawing.Size(121, 28);
            this.lbUnitInStock.TabIndex = 21;
            this.lbUnitInStock.Text = "Unit in stock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUnitPrice.Location = new System.Drawing.Point(403, 67);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(96, 28);
            this.lbUnitPrice.TabIndex = 20;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnitInStock.Location = new System.Drawing.Point(531, 101);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(255, 27);
            this.txtUnitInStock.TabIndex = 28;
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWeight.Location = new System.Drawing.Point(531, 35);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(255, 27);
            this.txtWeight.TabIndex = 27;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnitPrice.Location = new System.Drawing.Point(531, 68);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(255, 27);
            this.txtUnitPrice.TabIndex = 26;
            // 
            // lbWeight
            // 
            this.lbWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWeight.Location = new System.Drawing.Point(403, 34);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(75, 28);
            this.lbWeight.TabIndex = 19;
            this.lbWeight.Text = "Weight";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(345, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 37);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckout.Location = new System.Drawing.Point(607, 161);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(104, 37);
            this.btnCheckout.TabIndex = 29;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbCategoryId);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lbUnitInStock);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.txtUnitInStock);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvProducts);
            this.Name = "frmCart";
            this.Text = "frmCart";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProducts;
        private Label lbProductName;
        private Label lbCategoryId;
        private Label lbProductId;
        private TextBox txtProductName;
        private TextBox txtCategoryId;
        private TextBox txtProductId;
        private Label lbUnitInStock;
        private Label lbUnitPrice;
        private TextBox txtUnitInStock;
        private TextBox txtWeight;
        private TextBox txtUnitPrice;
        private Label lbWeight;
        private Button btnDelete;
        private Button btnCheckout;
    }
}