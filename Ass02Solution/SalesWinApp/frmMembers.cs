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

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        string role = "";
        BindingSource source;
        public frmMembers()
        {
            InitializeComponent();
        }
        public frmMembers(string role)
        {
            InitializeComponent();
            this.role = role;
        }
        private void authorized(string role)
        {
            if (role == "2")
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }
        private void frmMember_Load(object sender, EventArgs e)
        {
               LoadMembers();
               authorized(role);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member
                {
                    MemberId = int.Parse(txtMemberId.Text),
                    Email = txtEmail.Text,
                    Passwords = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    CompanyName = txtCompanyName.Text,
                    RoleId = 2,
                };
                MessageBox.Show(MemberDAO.Instance.Insert(member),"ERROR");
                LoadMembers();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Create member");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int memberId;
            try
            {
                memberId = int.Parse(txtMemberId.Text);
                MemberDAO.Instance.Delete(memberId);
                LoadMembers();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void LoadMembers()
        {
            source = new BindingSource();
            var members = MemberDAO.Instance.GetMembers();
            txtMemberId.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtCompanyName.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            //Binding to textBox
            txtMemberId.DataBindings.Add("Text", members, "MemberId");
            txtEmail.DataBindings.Add("Text", members, "Email");
            txtCompanyName.DataBindings.Add("Text", members, "CompanyName");
            txtCity.DataBindings.Add("Text", members, "City");
            txtCountry.DataBindings.Add("Text", members, "Country");
            txtPassword.DataBindings.Add("Text", members, "Passwords");

            dgvMembers.DataSource = null;
            dgvMembers.DataSource = members;
            if(members.Count() == 0)
            {
                ClearText();
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private void ClearText()
        {
            txtMemberId.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty ;
            txtEmail.Text = string.Empty ;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMembers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
