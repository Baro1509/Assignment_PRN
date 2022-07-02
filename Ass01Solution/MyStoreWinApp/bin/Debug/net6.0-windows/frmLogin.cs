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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMemberManagement frmMemberManagement = new frmMemberManagement()
            {            
                
            };
            if (frmMemberManagement.ShowDialog() == DialogResult.OK)
            {
               
            }
        }



    }

}
