
namespace SalesWinApp
{
    partial class frmOrder
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
            System.Windows.Forms.TableLayoutPanel tblOrder;
            this.lbMemberId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.lbFreight = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            tblOrder = new System.Windows.Forms.TableLayoutPanel();
            tblOrder.SuspendLayout();
            this.tblButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblOrder
            // 
            tblOrder.ColumnCount = 4;
            tblOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.125F));
            tblOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.75F));
            tblOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.875F));
            tblOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.25F));
            tblOrder.Controls.Add(this.lbMemberId, 0, 1);
            tblOrder.Controls.Add(this.txtMemberId, 1, 1);
            tblOrder.Controls.Add(this.lbOrderId, 0, 0);
            tblOrder.Controls.Add(this.txtOrderId, 1, 0);
            tblOrder.Controls.Add(this.lbOrderDate, 2, 0);
            tblOrder.Controls.Add(this.lbRequiredDate, 2, 1);
            tblOrder.Controls.Add(this.txtOrderDate, 3, 0);
            tblOrder.Controls.Add(this.txtRequiredDate, 3, 1);
            tblOrder.Controls.Add(this.tblButton, 0, 4);
            tblOrder.Controls.Add(this.txtShippedDate, 3, 2);
            tblOrder.Controls.Add(this.lbShippedDate, 2, 2);
            tblOrder.Controls.Add(this.lbFreight, 0, 2);
            tblOrder.Controls.Add(this.txtFreight, 1, 2);
            tblOrder.Controls.Add(this.dataGridView1, 0, 5);
            tblOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            tblOrder.Location = new System.Drawing.Point(0, 0);
            tblOrder.Name = "tblOrder";
            tblOrder.RowCount = 6;
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tblOrder.Size = new System.Drawing.Size(795, 305);
            tblOrder.TabIndex = 5;
            // 
            // lbMemberId
            // 
            this.lbMemberId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMemberId.Location = new System.Drawing.Point(3, 35);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(110, 28);
            this.lbMemberId.TabIndex = 1;
            this.lbMemberId.Text = "Member ID";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMemberId.Location = new System.Drawing.Point(139, 36);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(246, 27);
            this.txtMemberId.TabIndex = 7;
            // 
            // lbOrderId
            // 
            this.lbOrderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOrderId.Location = new System.Drawing.Point(3, 2);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(87, 28);
            this.lbOrderId.TabIndex = 0;
            this.lbOrderId.Text = "Order ID";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderId.Location = new System.Drawing.Point(139, 3);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(246, 27);
            this.txtOrderId.TabIndex = 6;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOrderDate.Location = new System.Drawing.Point(391, 2);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(107, 28);
            this.lbOrderDate.TabIndex = 3;
            this.lbOrderDate.Text = "Order date";
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRequiredDate.Location = new System.Drawing.Point(391, 35);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(136, 28);
            this.lbRequiredDate.TabIndex = 4;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderDate.Location = new System.Drawing.Point(539, 3);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(246, 27);
            this.txtOrderDate.TabIndex = 10;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRequiredDate.Location = new System.Drawing.Point(539, 36);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(246, 27);
            this.txtRequiredDate.TabIndex = 11;
            // 
            // tblButton
            // 
            this.tblButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblButton.ColumnCount = 3;
            tblOrder.SetColumnSpan(this.tblButton, 4);
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblButton.Controls.Add(this.btnCreate, 1, 0);
            this.tblButton.Controls.Add(this.btnLoad, 0, 0);
            this.tblButton.Controls.Add(this.btnDelete, 2, 0);
            this.tblButton.Location = new System.Drawing.Point(3, 102);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButton.Size = new System.Drawing.Size(789, 51);
            this.tblButton.TabIndex = 16;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.Location = new System.Drawing.Point(342, 6);
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
            this.btnDelete.Location = new System.Drawing.Point(605, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 38);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtShippedDate.Location = new System.Drawing.Point(539, 69);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(246, 27);
            this.txtShippedDate.TabIndex = 8;
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbShippedDate.Location = new System.Drawing.Point(391, 68);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(131, 28);
            this.lbShippedDate.TabIndex = 5;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // lbFreight
            // 
            this.lbFreight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbFreight.AutoSize = true;
            this.lbFreight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFreight.Location = new System.Drawing.Point(3, 68);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(74, 28);
            this.lbFreight.TabIndex = 2;
            this.lbFreight.Text = "Freight";
            // 
            // txtFreight
            // 
            this.txtFreight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFreight.Location = new System.Drawing.Point(139, 69);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(246, 27);
            this.txtFreight.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblOrder.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(789, 143);
            this.dataGridView1.TabIndex = 17;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 305);
            this.Controls.Add(tblOrder);
            this.Name = "frmOrder";
            this.Text = "Order";
            tblOrder.ResumeLayout(false);
            tblOrder.PerformLayout();
            this.tblButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbMemberId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Label lbOrderId;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}