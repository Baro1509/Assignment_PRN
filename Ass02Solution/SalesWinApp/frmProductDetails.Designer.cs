
namespace SalesWinApp
{
    partial class frmProductDetails
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
            this.lbProductId = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lbCategoryId = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lbUnitInStock = new System.Windows.Forms.Label();
            this.txtUnitInStock = new System.Windows.Forms.TextBox();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboCategoryID = new System.Windows.Forms.ComboBox();
            tblMember = new System.Windows.Forms.TableLayoutPanel();
            tblMember.SuspendLayout();
            this.tblButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMember
            // 
            tblMember.ColumnCount = 2;
            tblMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.02941F));
            tblMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.97059F));
            tblMember.Controls.Add(this.lbProductId, 0, 0);
            tblMember.Controls.Add(this.txtProductId, 1, 0);
            tblMember.Controls.Add(this.lbCategoryId, 0, 1);
            tblMember.Controls.Add(this.lbProductName, 0, 2);
            tblMember.Controls.Add(this.txtProductName, 1, 2);
            tblMember.Controls.Add(this.lbWeight, 0, 3);
            tblMember.Controls.Add(this.txtWeight, 1, 3);
            tblMember.Controls.Add(this.lbUnitPrice, 0, 4);
            tblMember.Controls.Add(this.txtUnitPrice, 1, 4);
            tblMember.Controls.Add(this.lbUnitInStock, 0, 5);
            tblMember.Controls.Add(this.txtUnitInStock, 1, 5);
            tblMember.Controls.Add(this.tblButton, 0, 6);
            tblMember.Controls.Add(this.cboCategoryID, 1, 1);
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
            tblMember.Size = new System.Drawing.Size(424, 258);
            tblMember.TabIndex = 6;
            // 
            // lbProductId
            // 
            this.lbProductId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbProductId.AutoSize = true;
            this.lbProductId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductId.Location = new System.Drawing.Point(3, 2);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(105, 28);
            this.lbProductId.TabIndex = 0;
            this.lbProductId.Text = "Product ID";
            // 
            // txtProductId
            // 
            this.txtProductId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductId.Location = new System.Drawing.Point(161, 3);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(253, 27);
            this.txtProductId.TabIndex = 6;
            // 
            // lbCategoryId
            // 
            this.lbCategoryId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCategoryId.AutoSize = true;
            this.lbCategoryId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCategoryId.Location = new System.Drawing.Point(3, 36);
            this.lbCategoryId.Name = "lbCategoryId";
            this.lbCategoryId.Size = new System.Drawing.Size(116, 28);
            this.lbCategoryId.TabIndex = 1;
            this.lbCategoryId.Text = "Category ID";
            // 
            // lbProductName
            // 
            this.lbProductName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductName.Location = new System.Drawing.Point(3, 69);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(138, 28);
            this.lbProductName.TabIndex = 5;
            this.lbProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.Location = new System.Drawing.Point(161, 70);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(253, 27);
            this.txtProductName.TabIndex = 8;
            // 
            // lbWeight
            // 
            this.lbWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWeight.Location = new System.Drawing.Point(3, 102);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(75, 28);
            this.lbWeight.TabIndex = 2;
            this.lbWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWeight.Location = new System.Drawing.Point(160, 103);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(255, 27);
            this.txtWeight.TabIndex = 10;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUnitPrice.Location = new System.Drawing.Point(3, 135);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(96, 28);
            this.lbUnitPrice.TabIndex = 3;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnitPrice.Location = new System.Drawing.Point(160, 136);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(255, 27);
            this.txtUnitPrice.TabIndex = 9;
            // 
            // lbUnitInStock
            // 
            this.lbUnitInStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUnitInStock.AutoSize = true;
            this.lbUnitInStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUnitInStock.Location = new System.Drawing.Point(3, 168);
            this.lbUnitInStock.Name = "lbUnitInStock";
            this.lbUnitInStock.Size = new System.Drawing.Size(121, 28);
            this.lbUnitInStock.TabIndex = 4;
            this.lbUnitInStock.Text = "Unit in stock";
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnitInStock.Location = new System.Drawing.Point(160, 169);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(255, 27);
            this.txtUnitInStock.TabIndex = 11;
            // 
            // tblButton
            // 
            this.tblButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblButton.ColumnCount = 2;
            tblMember.SetColumnSpan(this.tblButton, 2);
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblButton.Controls.Add(this.btnCancel, 1, 0);
            this.tblButton.Controls.Add(this.btnSave, 0, 0);
            this.tblButton.Location = new System.Drawing.Point(3, 203);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButton.Size = new System.Drawing.Size(418, 51);
            this.tblButton.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(261, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 38);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(52, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 38);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboCategoryID
            // 
            this.cboCategoryID.AutoCompleteCustomSource.AddRange(new string[] {
            "Car",
            "Book"});
            this.cboCategoryID.FormattingEnabled = true;
            this.cboCategoryID.Items.AddRange(new object[] {
            "1 - Car",
            "2 - Book"});
            this.cboCategoryID.Location = new System.Drawing.Point(155, 36);
            this.cboCategoryID.Name = "cboCategoryID";
            this.cboCategoryID.Size = new System.Drawing.Size(257, 28);
            this.cboCategoryID.TabIndex = 17;
            // 
            // frmProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 258);
            this.Controls.Add(tblMember);
            this.Name = "frmProductDetails";
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.frmProductDetails_Load);
            tblMember.ResumeLayout(false);
            tblMember.PerformLayout();
            this.tblButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbCategoryId;
        private System.Windows.Forms.Label lbProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lbUnitInStock;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.TextBox txtUnitInStock;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lbWeight;
        private ComboBox cboCategoryID;
    }
}