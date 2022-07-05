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
            this.lbOrderID = new System.Windows.Forms.Label();
            this.dvgOrderDetailsList = new System.Windows.Forms.DataGridView();
            this.lbOrderIdContent = new System.Windows.Forms.Label();
            this.lbNoPro = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotalContent = new System.Windows.Forms.Label();
            this.lbNoProContent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrderDetailsList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(30, 31);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(54, 15);
            this.lbOrderID.TabIndex = 0;
            this.lbOrderID.Text = "OrderID: ";
            this.lbOrderID.Click += new System.EventHandler(this.label1_Click);
            // 
            // dvgOrderDetailsList
            // 
            this.dvgOrderDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgOrderDetailsList.Location = new System.Drawing.Point(12, 117);
            this.dvgOrderDetailsList.Name = "dvgOrderDetailsList";
            this.dvgOrderDetailsList.RowTemplate.Height = 25;
            this.dvgOrderDetailsList.Size = new System.Drawing.Size(776, 321);
            this.dvgOrderDetailsList.TabIndex = 1;
            this.dvgOrderDetailsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgOrderDetailsList_CellClick);
            this.dvgOrderDetailsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgOrderDetailsList_CellContentClick);
            // 
            // lbOrderIdContent
            // 
            this.lbOrderIdContent.AutoSize = true;
            this.lbOrderIdContent.Location = new System.Drawing.Point(66, 57);
            this.lbOrderIdContent.Name = "lbOrderIdContent";
            this.lbOrderIdContent.Size = new System.Drawing.Size(0, 15);
            this.lbOrderIdContent.TabIndex = 2;
            // 
            // lbNoPro
            // 
            this.lbNoPro.AutoSize = true;
            this.lbNoPro.Location = new System.Drawing.Point(30, 72);
            this.lbNoPro.Name = "lbNoPro";
            this.lbNoPro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNoPro.Size = new System.Drawing.Size(118, 15);
            this.lbNoPro.TabIndex = 3;
            this.lbNoPro.Text = "Number of products:";
            this.lbNoPro.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(357, 72);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTotal.Size = new System.Drawing.Size(38, 15);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "Total: ";
            // 
            // lbTotalContent
            // 
            this.lbTotalContent.AutoSize = true;
            this.lbTotalContent.Location = new System.Drawing.Point(401, 72);
            this.lbTotalContent.Name = "lbTotalContent";
            this.lbTotalContent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTotalContent.Size = new System.Drawing.Size(0, 15);
            this.lbTotalContent.TabIndex = 6;
            // 
            // lbNoProContent
            // 
            this.lbNoProContent.AutoSize = true;
            this.lbNoProContent.Location = new System.Drawing.Point(154, 72);
            this.lbNoProContent.Name = "lbNoProContent";
            this.lbNoProContent.Size = new System.Drawing.Size(0, 15);
            this.lbNoProContent.TabIndex = 7;
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbNoProContent);
            this.Controls.Add(this.lbTotalContent);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbNoPro);
            this.Controls.Add(this.lbOrderIdContent);
            this.Controls.Add(this.dvgOrderDetailsList);
            this.Controls.Add(this.lbOrderID);
            this.Name = "frmOrderDetails";
            this.Text = "OrderDetails";
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrderDetailsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbOrderID;
        private DataGridView dvgOrderDetailsList;
        private Label lbOrderIdContent;
        private Label lbNoPro;
        private Label lbTotal;
        private Label lbTotalContent;
        private Label lbNoProContent;
    }
}