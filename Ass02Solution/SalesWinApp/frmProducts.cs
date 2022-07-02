using BusinessObject.EntityModels;
using DataAccess.Repository;
using System.Collections.Generic;

namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        public IProductRepositoy ProductRepository { get; set; }
        public int RoleID;
        BindingSource source;
        public frmProducts()
        {
            InitializeComponent();
        }

        public void ClearText()
        {
            txtProductId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtSearch.Text = string.Empty;
            txtCategoryId.Text = string.Empty;
            txtUnitInStock.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }

        public void LoadProducts(IEnumerable<Product>? products)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = products;

                txtProductId.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtUnitInStock.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                //Binding to TextBoxes
                txtProductId.DataBindings.Add("Text", products, "ProductID");
                txtCategoryId.DataBindings.Add("Text", products, "CategoryID");
                txtProductName.DataBindings.Add("Text", products, "ProductName");
                txtUnitInStock.DataBindings.Add("Text", products, "UnitsInStock");
                txtUnitPrice.DataBindings.Add("Text", products, "UnitPrice");
                txtWeight.DataBindings.Add("Text", products, "Weights");

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = source;
                if (RoleID == 1)
                {
                    btnDelete.Enabled = true;
                    btnCreate.Enabled = true;
                }
                if (products.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                    btnCreate.Enabled = false;
                }
                if (RoleID != 1)
                {
                    btnDelete.Enabled = false;
                    btnCreate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }

        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            if (RoleID != 1)
            {
                btnCreate.Enabled = false;
            }
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            ProductRepository = new ProductRepository();
            var products = ProductRepository.GetAllProducts();
            LoadProducts(products);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (RoleID == 1)
            {
                frmProductDetails frmProductDetails = new frmProductDetails
                {
                    Text = "Add product",
                    InsertOrUpdate = false,
                    ProductRepository = ProductRepository,
                    RoleID = RoleID
                };
                if (frmProductDetails.ShowDialog() == DialogResult.OK)
                {
                    ProductRepository = new ProductRepository();
                    var products = ProductRepository.GetAllProducts();
                    LoadProducts(products);
                    //set focus product updated
                    source.Position = source.Count - 1;
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            if (cboSearch.SelectedIndex == 0)
            {
                ProductRepository = new ProductRepository();
                var product = ProductRepository.GetProductByID(int.Parse(search));
                IEnumerable<Product>? result = new List<Product>();
                if (product != null)
                {
                    ((List<Product>)result).Add(product);
                }
                LoadProducts(result);
            }
            if (cboSearch.SelectedIndex == 1)
            {
                ProductRepository = new ProductRepository();
                var products = ProductRepository.GetProducts(search);
                LoadProducts(products);
            }
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RoleID == 1) // Admin role
            {
                frmProductDetails frmProductDetails = new frmProductDetails
                {
                    Text = "Update product",
                    InsertOrUpdate = true,
                    Product = GetProduct(),
                    ProductRepository = ProductRepository,
                    RoleID = RoleID
                };
                if (frmProductDetails.ShowDialog() == DialogResult.OK)
                {
                    ProductRepository = new ProductRepository();
                    var products = ProductRepository.GetAllProducts();
                    LoadProducts(products);
                    //Set focus product updated
                    source.Position = source.Count - 1;
                }
            }

        }

        private Product? GetProduct()
        {
            Product? product = null;
            try
            {
                product = new Product
                {
                    ProductId = int.Parse(txtProductId.Text),
                    ProductName = txtProductName.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitInStock.Text),
                    CategoryId = int.Parse(txtCategoryId.Text),
                    Weights = txtWeight.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }
            return product;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (RoleID == 1) // Admin Role
                {
                    var product = GetProduct();
                    ProductRepository.Delete(product);
                    ProductRepository = new ProductRepository();
                    var products = ProductRepository.GetAllProducts();
                    LoadProducts(products);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a product");
            }
        }
    }
}
