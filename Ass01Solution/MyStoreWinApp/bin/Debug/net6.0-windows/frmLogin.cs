using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ass01BusinessObject;
using Ass01DataAccess;
using DataAccess.Repository;


namespace MyStoreWinApp {
    public partial class frmLogin : Form 
    {
        IMemberRepository mbrepository = new MemberRepository();
        public frmLogin() {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string MemberName = txtMemberName.Text;
            string Password = txtPassword.Text;
            MemberObject login = mbrepository.Login(MemberName,Password);
            if (login != null)
            {
                int check = login.MemberID;
                frmMemberManagement frmMemberManagement = null;
                if (check==0)
                {
                    frmMemberManagement = new frmMemberManagement
                    {
                        loginMember = login,
                    };
                    frmMemberManagement.Closed += (s, args) => this.Close();
                    this.Hide();
                    frmMemberManagement.Show();
                }
                else
                {
                    frmMemberDetails frmMemberDetails = new frmMemberDetails
                    {
                        Text = "Member Details",
                        MemberInfo = login,
                        InsertOrUpdate = false,
                        MBRepository = mbrepository
                    };
                    frmMemberDetails.Closed += (s, args) => this.Close();
                    this.Hide();
                    frmMemberDetails.Show();
                }
            }
            else
            {
                if (MessageBox.Show("Login failed, Please try again", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();       
    }

}
