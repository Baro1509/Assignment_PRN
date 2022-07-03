using BusinessObject.EntityModels;
using DataAccess.Repository;
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
    public partial class frmProductDetails : Form
    {
        public IProductRepositoy ProductRepository { get; set; }
        public int RoleID;
        public Product Product { get; set; }
        public bool InsertOrUpdate { get; set; } // False: Insert

        public frmProductDetails()
        {
            InitializeComponent();
        }

        private void LockUpdate()
        {
            txtProductId.Enabled = false;
            txtProductName.Enabled = false;
            txtUnitInStock.Enabled = false;
            txtUnitPrice.Enabled = false;
            txtWeight.Enabled = false;
            cboCategoryID.Enabled = false;
            btnSave.Text = "Add to cart";
        }
        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            txtProductId.Enabled = false;
            if (InsertOrUpdate == true) //Update mode
            {
                cboCategoryID.SelectedIndex = Product.CategoryId - 1;
                txtProductId.Text = Product.ProductId.ToString();
                txtProductName.Text = Product.ProductName;
                txtUnitInStock.Text = Product.UnitsInStock.ToString();
                txtWeight.Text = Product.Weights.ToString();
                txtUnitPrice.Text = Product.UnitPrice.ToString();
            }
            if (RoleID != 1) // Other than admin
            {
                LockUpdate();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    CategoryId = cboCategoryID.SelectedIndex + 1,
                    ProductName = txtProductName.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitInStock.Text),
                    Weights = txtWeight.Text
                };
                ProductRepository = new ProductRepository();
                if (InsertOrUpdate == false) //Insert Mode
                {
                    ProductRepository.Insert(product);
                }
                else
                {
                    product.ProductId = int.Parse(txtProductId.Text);
                    ProductRepository.Update(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new product" : "Update product");
            }
            finally
            {
                if (InsertOrUpdate == false) //Insert Mode
                {
                    MessageBox.Show("Insert successfully");
                }
                else
                {
                    MessageBox.Show("Update successfully");
                }
                Close();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

    }
}
