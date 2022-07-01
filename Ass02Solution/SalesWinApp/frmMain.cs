<<<<<<< HEAD
﻿using System;
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
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //check role sau khi log in
            //neu la user thi unenable menuManageMember, menuManageOrder, menuManageOrder
        }

        private void menuManageMember_Click(object sender, EventArgs e)
        {
            frmMember frmMember = new frmMember();
            frmMember.Show();
        }

        private void menuManageProduct_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
            frmProduct.Show();

        }

        private void menuManageOrder_Click(object sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder();
            frmOrder.Show();
        }

        private void menuViewOrderHistory_Click(object sender, EventArgs e)
        {
            
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
    }
}
=======
namespace SalesWinApp {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }
    }
}
>>>>>>> origin/devs_baohlg
