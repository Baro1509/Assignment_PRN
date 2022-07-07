
namespace SalesWinApp
{
    partial class frmOrderDetails
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
            this.lbFreight = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            tblOrder = new System.Windows.Forms.TableLayoutPanel();
            tblOrder.SuspendLayout();
            this.tblButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblOrder
            // 
            tblOrder.ColumnCount = 2;
            tblOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblOrder.Controls.Add(this.lbMemberId, 0, 1);
            tblOrder.Controls.Add(this.txtMemberId, 1, 1);
            tblOrder.Controls.Add(this.lbOrderId, 0, 0);
            tblOrder.Controls.Add(this.txtOrderId, 1, 0);
            tblOrder.Controls.Add(this.lbFreight, 0, 2);
            tblOrder.Controls.Add(this.txtFreight, 1, 2);
            tblOrder.Controls.Add(this.tblButton, 0, 6);
            tblOrder.Controls.Add(this.lbOrderDate, 0, 3);
            tblOrder.Controls.Add(this.lbRequiredDate, 0, 4);
            tblOrder.Controls.Add(this.lbShippedDate, 0, 5);
            tblOrder.Controls.Add(this.txtShippedDate, 1, 5);
            tblOrder.Controls.Add(this.txtRequiredDate, 1, 4);
            tblOrder.Controls.Add(this.txtOrderDate, 1, 3);
            tblOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            tblOrder.Location = new System.Drawing.Point(0, 0);
            tblOrder.Name = "tblOrder";
            tblOrder.RowCount = 7;
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblOrder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblOrder.Size = new System.Drawing.Size(400, 257);
            tblOrder.TabIndex = 6;
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
            this.txtMemberId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMemberId.Location = new System.Drawing.Point(145, 36);
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
            this.txtOrderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOrderId.Location = new System.Drawing.Point(145, 3);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(246, 27);
            this.txtOrderId.TabIndex = 6;
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
            this.txtFreight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFreight.Location = new System.Drawing.Point(145, 69);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(246, 27);
            this.txtFreight.TabIndex = 9;
            // 
            // tblButton
            // 
            this.tblButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblButton.ColumnCount = 2;
            tblOrder.SetColumnSpan(this.tblButton, 2);
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblButton.Controls.Add(this.btnCancel, 1, 0);
            this.tblButton.Controls.Add(this.btnSave, 0, 0);
            this.tblButton.Location = new System.Drawing.Point(3, 202);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButton.Size = new System.Drawing.Size(397, 51);
            this.tblButton.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(245, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 38);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(47, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 38);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOrderDate.Location = new System.Drawing.Point(3, 101);
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
            this.lbRequiredDate.Location = new System.Drawing.Point(3, 134);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(136, 28);
            this.lbRequiredDate.TabIndex = 4;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbShippedDate.Location = new System.Drawing.Point(3, 167);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(131, 28);
            this.lbShippedDate.TabIndex = 5;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtShippedDate.Location = new System.Drawing.Point(145, 168);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(246, 27);
            this.txtShippedDate.TabIndex = 8;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRequiredDate.Location = new System.Drawing.Point(145, 135);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(246, 27);
            this.txtRequiredDate.TabIndex = 11;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOrderDate.Location = new System.Drawing.Point(145, 102);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(246, 27);
            this.txtOrderDate.TabIndex = 10;
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 257);
            this.Controls.Add(tblOrder);
            this.Name = "frmOrderDetails";
            this.Text = "Order Details";
            tblOrder.ResumeLayout(false);
            tblOrder.PerformLayout();
            this.tblButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbMemberId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lbOrderId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.TextBox txtFreight;
    }
}