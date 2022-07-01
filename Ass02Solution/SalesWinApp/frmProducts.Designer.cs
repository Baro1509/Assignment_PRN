
namespace SalesWinApp
{
    partial class frmProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TableLayoutPanel tblMember;
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            tblMember = new System.Windows.Forms.TableLayoutPanel();
            tblMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tblButton.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMember
            // 
            tblMember.ColumnCount = 4;
            tblMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.375F));
            tblMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.625F));
            tblMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            tblMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            tblMember.Controls.Add(this.dgvProducts, 2, 5);
            tblMember.Controls.Add(this.tblButton, 0, 4);
            tblMember.Controls.Add(this.lbProductName, 0, 3);
            tblMember.Controls.Add(this.lbCategoryId, 0, 2);
            tblMember.Controls.Add(this.lbProductId, 0, 1);
            tblMember.Controls.Add(this.txtProductName, 1, 3);
            tblMember.Controls.Add(this.txtCategoryId, 1, 2);
            tblMember.Controls.Add(this.txtProductId, 1, 1);
            tblMember.Controls.Add(this.lbUnitInStock, 2, 3);
            tblMember.Controls.Add(this.lbUnitPrice, 2, 2);
            tblMember.Controls.Add(this.txtUnitInStock, 3, 3);
            tblMember.Controls.Add(this.txtWeight, 3, 1);
            tblMember.Controls.Add(this.txtUnitPrice, 3, 2);
            tblMember.Controls.Add(this.lbWeight, 2, 1);
            tblMember.Controls.Add(this.flowLayoutPanel1, 0, 0);
            tblMember.Dock = System.Windows.Forms.DockStyle.Fill;
            tblMember.Location = new System.Drawing.Point(0, 0);
            tblMember.Name = "tblMember";
            tblMember.RowCount = 7;
            tblMember.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblMember.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblMember.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblMember.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblMember.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblMember.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblMember.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblMember.Size = new System.Drawing.Size(794, 523);
            tblMember.TabIndex = 5;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMember.SetColumnSpan(this.dgvProducts, 4);
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(3, 199);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.Size = new System.Drawing.Size(788, 430);
            this.dgvProducts.TabIndex = 12;
            // 
            // tblButton
            // 
            this.tblButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblButton.ColumnCount = 3;
            tblMember.SetColumnSpan(this.tblButton, 4);
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblButton.Controls.Add(this.btnCreate, 1, 0);
            this.tblButton.Controls.Add(this.btnLoad, 0, 0);
            this.tblButton.Controls.Add(this.btnDelete, 2, 0);
            this.tblButton.Location = new System.Drawing.Point(3, 142);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButton.Size = new System.Drawing.Size(788, 51);
            this.tblButton.TabIndex = 16;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.Location = new System.Drawing.Point(341, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 38);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoad.Location = new System.Drawing.Point(79, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 38);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(604, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 38);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbProductName
            // 
            this.lbProductName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductName.Location = new System.Drawing.Point(3, 108);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(138, 28);
            this.lbProductName.TabIndex = 5;
            this.lbProductName.Text = "Product Name";
            // 
            // lbCategoryId
            // 
            this.lbCategoryId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCategoryId.AutoSize = true;
            this.lbCategoryId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCategoryId.Location = new System.Drawing.Point(3, 75);
            this.lbCategoryId.Name = "lbCategoryId";
            this.lbCategoryId.Size = new System.Drawing.Size(116, 28);
            this.lbCategoryId.TabIndex = 1;
            this.lbCategoryId.Text = "Category ID";
            // 
            // lbProductId
            // 
            this.lbProductId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbProductId.AutoSize = true;
            this.lbProductId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductId.Location = new System.Drawing.Point(3, 42);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(105, 28);
            this.lbProductId.TabIndex = 0;
            this.lbProductId.Text = "Product ID";
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.Location = new System.Drawing.Point(148, 109);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(253, 27);
            this.txtProductName.TabIndex = 8;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoryId.Location = new System.Drawing.Point(148, 76);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(253, 27);
            this.txtCategoryId.TabIndex = 7;
            // 
            // txtProductId
            // 
            this.txtProductId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductId.Location = new System.Drawing.Point(148, 43);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(253, 27);
            this.txtProductId.TabIndex = 6;
            // 
            // lbUnitInStock
            // 
            this.lbUnitInStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUnitInStock.AutoSize = true;
            this.lbUnitInStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUnitInStock.Location = new System.Drawing.Point(407, 108);
            this.lbUnitInStock.Name = "lbUnitInStock";
            this.lbUnitInStock.Size = new System.Drawing.Size(121, 28);
            this.lbUnitInStock.TabIndex = 4;
            this.lbUnitInStock.Text = "Unit in stock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUnitPrice.Location = new System.Drawing.Point(407, 75);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(96, 28);
            this.lbUnitPrice.TabIndex = 3;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnitInStock.Location = new System.Drawing.Point(535, 109);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(255, 27);
            this.txtUnitInStock.TabIndex = 11;
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWeight.Location = new System.Drawing.Point(535, 43);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(255, 27);
            this.txtWeight.TabIndex = 10;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnitPrice.Location = new System.Drawing.Point(535, 76);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(255, 27);
            this.txtUnitPrice.TabIndex = 9;
            // 
            // lbWeight
            // 
            this.lbWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWeight.Location = new System.Drawing.Point(407, 42);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(75, 28);
            this.lbWeight.TabIndex = 2;
            this.lbWeight.Text = "Weight";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            tblMember.SetColumnSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Controls.Add(this.cbSearch);
            this.flowLayoutPanel1.Controls.Add(this.txtSearch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(788, 34);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(681, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Product ID",
            "Product Name",
            "Unit price",
            "Unit in stock"});
            this.cbSearch.Location = new System.Drawing.Point(537, 3);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(138, 28);
            this.cbSearch.TabIndex = 0;
            this.cbSearch.Text = "Product ID";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(9, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(522, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 523);
            this.Controls.Add(tblMember);
            this.Name = "frmProducts";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            tblMember.ResumeLayout(false);
            tblMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tblButton.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCategoryId;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lbProductId;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbUnitInStock;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtUnitInStock;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}