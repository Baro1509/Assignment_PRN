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

        private bool CheckValid()
        {
            if (cboCategoryID.SelectedIndex <= -1)
            {
                return false;
            }
            // Product name must have length in range [1,50]
            if (txtProductName.Text.Length < 1 || txtProductName.Text.Length > 50)
            {
                return false;

            }
            // Weight must have length in range [1,50]
            if (txtWeight.Text.Length < 1 || txtWeight.Text.Length > 50)
            {
                return false;

            }

            // Unit in stock must be an integer that is not negative and smaller than 10^9
            int integer;
            if (txtUnitInStock.Text.Length < 1 || txtUnitInStock.Text.Length > 9 || !int.TryParse(txtUnitInStock.Text, out integer))
            {
                return false;

            }
            if (integer < 0)
            {
                return false;
            }

            // Unit in stock must be an integer that is not negative and smaller than 10^9
            decimal moneyValue;
            if (txtUnitPrice.Text.Length < 1 || txtUnitPrice.Text.Length > 9 || !decimal.TryParse(txtUnitPrice.Text, out moneyValue))
            {
                return false;
            }
            if (moneyValue < 0)
            {
                return false;
            }
            return true;
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
                if (CheckValid())
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
                        MessageBox.Show("Insert product successfully");
                    }
                    else
                    {
                        product.ProductId = int.Parse(txtProductId.Text);
                        ProductRepository.Update(product);
                        MessageBox.Show("Update product successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Your input data is not valid!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new product" : "Update product");
            }
            finally
            {
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

    }
}
