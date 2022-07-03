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
    public partial class frmMemberManagement : Form {

        public MemberObject loginMember { get; set; }
        IMemberRepository memberRepository = new MemberRepository();

        BindingSource source;
        public frmMemberManagement() {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellContentClick;
        }

        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmDetails = new frmMemberDetails()
            {
                Text = "Update Users",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                MBRepository = memberRepository
            };
            if (frmDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            

        }

        private MemberObject GetMemberObject()
        {
            MemberObject memberObject = null;
            try
            {
                memberObject = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,

                };
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return memberObject;
        }

        public void LoadMemberList(bool search = false, IEnumerable<MemberObject> searchDataSource = null)
        {
            var members = memberRepository.GetMembers();
            var memberList = from member in members
                             orderby member.MemberName descending
                             select member;
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (memberList.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmDetails = new frmMemberDetails()
            {
                Text = "Add Member",
                InsertOrUpdate = false,
                MBRepository = memberRepository
            };

            if(frmDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberID);
                LoadMemberList();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a Member");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtSearchValue.Text;
                if (radioByID.Checked)
                {
                    int searchID = int.Parse(searchValue);
                    IEnumerable<MemberObject> searchResult = memberRepository.SearchMember(searchID);
                    if (searchResult.Any())
                    {
                        LoadMemberList(true, searchResult);
                    }
                    else
                    {
                        MessageBox.Show("No result found!", "Search member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (radioByName.Checked)
                {
                    string searchName = searchValue;
                    IEnumerable<MemberObject> searchResult = memberRepository.SearchMember(searchName);
                    if (searchResult.Any())
                    {
                        LoadMemberList(true, searchResult);
                    }
                    else
                    {
                        MessageBox.Show("No result found!", "Search member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
