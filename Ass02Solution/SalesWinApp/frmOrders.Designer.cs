namespace SalesWinApp
{
    partial class frmOrders
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
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dvgOrderList = new System.Windows.Forms.DataGridView();
            this.lbStartDay = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.lbNoti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(356, 44);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.Location = new System.Drawing.Point(92, 21);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(200, 23);
            this.dtpStartDay.TabIndex = 1;
            this.dtpStartDay.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(92, 63);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 23);
            this.dtpEndDate.TabIndex = 2;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dvgOrderList
            // 
            this.dvgOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgOrderList.Location = new System.Drawing.Point(12, 136);
            this.dvgOrderList.Name = "dvgOrderList";
            this.dvgOrderList.RowTemplate.Height = 25;
            this.dvgOrderList.Size = new System.Drawing.Size(710, 235);
            this.dvgOrderList.TabIndex = 3;
            this.dvgOrderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgOrderList_CellContentClick);
            this.dvgOrderList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgOrderList_CellMouseDoubleClick);
            // 
            // lbStartDay
            // 
            this.lbStartDay.AutoSize = true;
            this.lbStartDay.Location = new System.Drawing.Point(29, 27);
            this.lbStartDay.Name = "lbStartDay";
            this.lbStartDay.Size = new System.Drawing.Size(53, 15);
            this.lbStartDay.TabIndex = 4;
            this.lbStartDay.Text = "Start day";
            this.lbStartDay.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(29, 69);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(53, 15);
            this.lbEndDate.TabIndex = 5;
            this.lbEndDate.Text = "End date";
            this.lbEndDate.Click += new System.EventHandler(this.lbEndDate_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(522, 44);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 6;
            this.btnViewAll.Text = "View all";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // lbNoti
            // 
            this.lbNoti.AutoSize = true;
            this.lbNoti.Location = new System.Drawing.Point(32, 99);
            this.lbNoti.Name = "lbNoti";
            this.lbNoti.Size = new System.Drawing.Size(0, 15);
            this.lbNoti.TabIndex = 7;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 383);
            this.Controls.Add(this.lbNoti);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbStartDay);
            this.Controls.Add(this.dvgOrderList);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDay);
            this.Controls.Add(this.btnFilter);
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnFilter;
        private DateTimePicker dtpStartDay;
        private DateTimePicker dtpEndDate;
        private DataGridView dvgOrderList;
        private Label lbStartDay;
        private Label lbEndDate;
        private Button btnViewAll;
        private Label lbNoti;
    }
}