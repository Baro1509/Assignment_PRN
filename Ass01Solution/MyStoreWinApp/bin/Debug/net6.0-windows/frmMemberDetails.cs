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
using Ass01BusinessObject;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public frmMemberDetails()
        {
            InitializeComponent();
        }

        public IMemberRepository MBRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MemberObject MemberInfo { get; set; }

        private void frmMemberDetails_Load(object sender,EventArgs e)
        {
            if (InsertOrUpdate) 
            {
                              

            }
            else
            {
               
                
                txtMemberID.Enabled = false;
                txtMemberName.Text = MemberInfo.MemberName;
                txtEmail.Text = MemberInfo.Email;
                txtPassword.Text = MemberInfo.Password;
                txtCity.Text = MemberInfo.City;
                txtCountry.Text = MemberInfo.Country;
               
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject member = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
                if (InsertOrUpdate == false)
                {
                    MBRepository.InsertMember(member);
                }
                else
                {
                    MBRepository.UpdateMember(member);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) =>Close();
        
    }
}
