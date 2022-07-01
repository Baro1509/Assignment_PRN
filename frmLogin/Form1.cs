using DataAccess;

namespace frmLogin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lbUserName_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEmail.Text == "")
                {
                    MessageBox.Show("Email can't empty!");
                }else if(txtPassword.Text == "")
                {
                    MessageBox.Show("Password can't empty!");
                }
                else
                {
                    var member = new Member
                    {
                        email = txtEmail.Text,
                        password = txtPassword.Text
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Login");
            }
        }
    }
}