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
                Boolean check = MemberManage.Instance.checkLogin(member);
                if (check)
                {
                    MessageBox.Show("Login success!");
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

    }

    private void frmLogin_Load(object sender, EventArgs e)
    {

    }
}
