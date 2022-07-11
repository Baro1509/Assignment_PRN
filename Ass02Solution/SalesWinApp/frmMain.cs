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
    public partial class frmMain : Form
    {
        readonly Member mem;
        readonly Cart Cart;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(Member mem)
        {
            InitializeComponent();
            this.mem = mem;
            Cart = new Cart(mem);
        }
        private void authorized(int role)
        {

            if (role == 2)
            {
                menuManageMember.Visible = false;
                menuManageOrder.Visible = false;
                menuManageProduct.Visible = false;
                menuManageMember.Visible = false;
                cartToolStripMenuItem.Visible = true;
            }
            else
            {
                menuManageMember.Visible = true;
                menuManageOrder.Visible = true;
                menuManageProduct.Visible = true;
                menuManageMember.Visible = true;
                cartToolStripMenuItem.Visible = false;
                btnBuyProduct.Enabled = false;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            authorized(mem.RoleId);
            //check role sau khi log in
            //neu la user thi unenable menuManageMember, menuManageOrder, menuManageOrder
        }

        private void menuManageMember_Click(object sender, EventArgs e)
        {
            frmMembers frmMember = new frmMembers(mem.RoleId.ToString());
            frmMember.Show();
        }

        private void menuManageProduct_Click(object sender, EventArgs e)
        {
            frmProducts frmProduct = new frmProducts(mem);
            frmProduct.Show();
        }

        private void menuManageOrder_Click(object sender, EventArgs e)
        {
            frmOrders frmOrder = new frmOrders(mem);
            frmOrder.Show();
        }

        private void menuViewOrderHistory_Click(object sender, EventArgs e)
        {
            frmOrders frmOrder = new frmOrders(mem);
            frmOrder.Show();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicks project and choose what you want to do\n\n" +
                "Click 'Load' button to load the form\n" +
                "Click 'Create' button to create new item\n" +
                "Click 'Delete' button to delete the choose item\n" +
                "DoubleClick the item to update the item\n");
        }

        private void menuProject_Click(object sender, EventArgs e)
        {

        }

        private void btnBuyProduct_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts(mem, Cart);
            frmProducts.Show();
        }
    }
}
