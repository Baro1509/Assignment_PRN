using BusinessObject.EntityModels;
using DataAccess.Repository;
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
    public partial class frmMemberDetails : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        Member mem;
        public frmMemberDetails()
        {
            InitializeComponent();
        }
        public frmMemberDetails(Member member)
        {
            InitializeComponent();
            this.mem = member;
        }
        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txtMemberId.Enabled = false;
            txtCity.Text = mem.City.ToString();
            txtCountry.Text = mem.Country.ToString();
            txtCompanyName.Text = mem.CompanyName.ToString();
            txtEmail.Text = mem.Email.ToString();
            txtMemberId.Text = mem.MemberId.ToString();
            txtPassword.Text = mem.Passwords.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = new Member
                {
                    MemberId = int.Parse(txtMemberId.Text),
                    Passwords = txtPassword.Text,
                    City = txtCity.Text,
                    CompanyName = txtCompanyName.Text,
                    Country = txtCountry.Text,
                    Email = txtEmail.Text,
                    RoleId = 2
                };
                //MemberRepository = new MemberRepository();
                //MemberRepository.UpdateMember(member);
                MemberDAO.Instance.Update(member);
                MessageBox.Show("Update successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
