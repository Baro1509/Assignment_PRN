using BusinessObject.EntityModels;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;

namespace SalesWinApp;

public partial class frmLogin : Form
{
    public frmLogin()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Email can't empty!");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password can't empty!");
            }
            else
            {
                var member = new Member
                {
                    Email = txtEmail.Text,
                    Passwords = txtPassword.Text
                };
                int role = MemberDAO.Instance.checkLogin(member);
                if (role==1|role==2)
                {
                    Member mem=MemberDAO.Instance.GetMember(member);
                    var frm = new frmMain(mem);
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormClosing += delegate { this.Show(); };
                    frm.Show();
                    // frm.ShowDialOG();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password!");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Login");
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void frmLogin_Load(object sender, EventArgs e)
    {

    }
}
