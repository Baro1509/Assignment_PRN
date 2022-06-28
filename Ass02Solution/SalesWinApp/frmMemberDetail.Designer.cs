
namespace SalesWinApp
{
    partial class frmMemberDetail
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
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            tblMember = new System.Windows.Forms.TableLayoutPanel();
            tblMember.SuspendLayout();
            this.tblButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMember
            // 
            tblMember.ColumnCount = 2;
            tblMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblMember.Controls.Add(this.lbEmail, 0, 1);
            tblMember.Controls.Add(this.txtEmail, 1, 1);
            tblMember.Controls.Add(this.txtPassword, 1, 2);
            tblMember.Controls.Add(this.lbMemberId, 0, 0);
            tblMember.Controls.Add(this.txtMemberId, 1, 0);
            tblMember.Controls.Add(this.lbPassword, 0, 2);
            tblMember.Controls.Add(this.lbCompanyName, 0, 3);
            tblMember.Controls.Add(this.txtCompanyName, 1, 3);
            tblMember.Controls.Add(this.lbCity, 0, 4);
            tblMember.Controls.Add(this.txtCity, 1, 4);
            tblMember.Controls.Add(this.tblButton, 0, 6);
            tblMember.Controls.Add(this.lbCountry, 0, 5);
            tblMember.Controls.Add(this.txtCountry, 1, 5);
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
            tblMember.Size = new System.Drawing.Size(399, 256);
            tblMember.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(3, 35);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(59, 28);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Location = new System.Drawing.Point(162, 36);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 27);
            this.txtEmail.TabIndex = 7;
            // 
            // lbMemberId
            // 
            this.lbMemberId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMemberId.Location = new System.Drawing.Point(3, 2);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(110, 28);
            this.lbMemberId.TabIndex = 0;
            this.lbMemberId.Text = "Member ID";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMemberId.Location = new System.Drawing.Point(162, 3);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(230, 27);
            this.txtMemberId.TabIndex = 6;
            // 
            // tblButton
            // 
            this.tblButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblButton.ColumnCount = 2;
            tblMember.SetColumnSpan(this.tblButton, 2);
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.Controls.Add(this.btnCancel, 1, 0);
            this.tblButton.Controls.Add(this.btnSave, 0, 0);
            this.tblButton.Location = new System.Drawing.Point(3, 201);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButton.Size = new System.Drawing.Size(396, 51);
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
            // lbCity
            // 
            this.lbCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCity.Location = new System.Drawing.Point(3, 134);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(46, 28);
            this.lbCity.TabIndex = 3;
            this.lbCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCity.Location = new System.Drawing.Point(162, 135);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(230, 27);
            this.txtCity.TabIndex = 10;
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCompanyName.Location = new System.Drawing.Point(3, 101);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(153, 28);
            this.lbCompanyName.TabIndex = 2;
            this.lbCompanyName.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCompanyName.Location = new System.Drawing.Point(162, 102);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(230, 27);
            this.txtCompanyName.TabIndex = 9;
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCountry.Location = new System.Drawing.Point(162, 168);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(230, 27);
            this.txtCountry.TabIndex = 11;
            // 
            // lbCountry
            // 
            this.lbCountry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCountry.Location = new System.Drawing.Point(3, 167);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(82, 28);
            this.lbCountry.TabIndex = 4;
            this.lbCountry.Text = "Country";
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(3, 68);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(93, 28);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.Location = new System.Drawing.Point(162, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(230, 27);
            this.txtPassword.TabIndex = 8;
            // 
            // frmMemberDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 256);
            this.Controls.Add(tblMember);
            this.Name = "frmMemberDetail";
            this.Text = "frmMemberDetail";
            tblMember.ResumeLayout(false);
            tblMember.PerformLayout();
            this.tblButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbMemberId;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
    }
}