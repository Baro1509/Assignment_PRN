namespace MyStoreWinApp {
    partial class frmMemberManagement {
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
<<<<<<< HEAD
            this.SuspendLayout();
            // 
=======
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.radioByName = new System.Windows.Forms.RadioButton();
            this.radioByCity = new System.Windows.Forms.RadioButton();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.radioCountry = new System.Windows.Forms.RadioButton();
            this.radioEmail = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.grSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(27, 18);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(84, 20);
            this.lbMemberID.TabIndex = 0;
            this.lbMemberID.Text = "Member ID";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(26, 58);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(109, 20);
            this.lbMemberName.TabIndex = 1;
            this.lbMemberName.Text = "Member Name";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(27, 120);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(26, 172);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(429, 18);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 4;
            this.lbCity.Text = "City";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(429, 70);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 5;
            this.lbCountry.Text = "Country";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(164, 18);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(211, 27);
            this.txtMemberID.TabIndex = 6;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(164, 67);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(211, 27);
            this.txtMemberName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(164, 113);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(164, 165);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(211, 27);
            this.txtPassword.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(495, 18);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(212, 27);
            this.txtCity.TabIndex = 10;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(495, 70);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(212, 27);
            this.txtCountry.TabIndex = 11;
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(26, 384);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 29;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(708, 188);
            this.dgvMemberList.TabIndex = 12;
            this.dgvMemberList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(369, 597);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(65, 222);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(369, 222);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(613, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.radioEmail);
            this.grSearch.Controls.Add(this.radioCountry);
            this.grSearch.Controls.Add(this.radioByName);
            this.grSearch.Controls.Add(this.radioByCity);
            this.grSearch.Controls.Add(this.txtSearchValue);
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.lbSearch);
            this.grSearch.Location = new System.Drawing.Point(26, 258);
            this.grSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grSearch.Name = "grSearch";
            this.grSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grSearch.Size = new System.Drawing.Size(569, 119);
            this.grSearch.TabIndex = 23;
            this.grSearch.TabStop = false;
            // 
            // radioByName
            // 
            this.radioByName.AutoSize = true;
            this.radioByName.Checked = true;
            this.radioByName.Location = new System.Drawing.Point(301, 76);
            this.radioByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioByName.Name = "radioByName";
            this.radioByName.Size = new System.Drawing.Size(90, 24);
            this.radioByName.TabIndex = 23;
            this.radioByName.TabStop = true;
            this.radioByName.Text = "By Name";
            this.radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByCity
            // 
            this.radioByCity.AutoSize = true;
            this.radioByCity.Location = new System.Drawing.Point(301, 29);
            this.radioByCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioByCity.Name = "radioByCity";
            this.radioByCity.Size = new System.Drawing.Size(75, 24);
            this.radioByCity.TabIndex = 22;
            this.radioByCity.TabStop = true;
            this.radioByCity.Text = "By City";
            this.radioByCity.UseVisualStyleBackColor = true;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(82, 24);
            this.txtSearchValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(134, 27);
            this.txtSearchValue.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(82, 69);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 31);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(27, 29);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(53, 20);
            this.lbSearch.TabIndex = 16;
            this.lbSearch.Text = "Search";
            // 
            // radioCountry
            // 
            this.radioCountry.AutoSize = true;
            this.radioCountry.Location = new System.Drawing.Point(436, 25);
            this.radioCountry.Name = "radioCountry";
            this.radioCountry.Size = new System.Drawing.Size(101, 24);
            this.radioCountry.TabIndex = 24;
            this.radioCountry.TabStop = true;
            this.radioCountry.Text = "By Country";
            this.radioCountry.UseVisualStyleBackColor = true;
            // 
            // radioEmail
            // 
            this.radioEmail.AutoSize = true;
            this.radioEmail.Location = new System.Drawing.Point(436, 76);
            this.radioEmail.Name = "radioEmail";
            this.radioEmail.Size = new System.Drawing.Size(87, 24);
            this.radioEmail.TabIndex = 25;
            this.radioEmail.TabStop = true;
            this.radioEmail.Text = "By Email";
            this.radioEmail.UseVisualStyleBackColor = true;
            // 
>>>>>>> origin/devs
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmMemberManagement";
            this.Text = "Member Management";
            this.ResumeLayout(false);
=======
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.lbMemberID);
            this.Name = "frmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> origin/devs

        }

        #endregion
<<<<<<< HEAD
=======

        private Label lbMemberID;
        private Label lbMemberName;
        private Label lbEmail;
        private Label lbPassword;
        private Label lbCity;
        private Label lbCountry;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtCity;
        private TextBox txtCountry;
        private DataGridView dgvMemberList;
        private Button btnClose;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private GroupBox grSearch;
        private RadioButton radioByName;
        private RadioButton radioByCity;
        private TextBox txtSearchValue;
        private Button btnSearch;
        private Label lbSearch;
        private RadioButton radioCountry;
        private RadioButton radioEmail;
>>>>>>> origin/devs
    }
}