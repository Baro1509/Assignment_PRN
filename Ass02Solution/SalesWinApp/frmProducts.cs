﻿using BusinessObject.EntityModels;
using DataAccess.Repository;
using System.Collections.Generic;

namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        public IProductRepositoy ProductRepository { get; set; }

        readonly Member mem;
        public int RoleID;
        readonly Cart Cart;
        BindingSource source;
        public frmProducts()
        {
            InitializeComponent();
        }
        public frmProducts(Member mem)
        {
            InitializeComponent();
            this.mem = mem;
            RoleID = mem.RoleId;
        }

        public frmProducts(Member mem, Cart cart)
        {
            InitializeComponent();
            this.mem = mem;
            RoleID = mem.RoleId;
            this.Cart = cart;
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
                System.Diagnostics.Debug.WriteLine(products.Count());

                txtProductId.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtUnitInStock.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                //Binding to TextBoxes
                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtUnitInStock.DataBindings.Add("Text", source, "UnitsInStock");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtWeight.DataBindings.Add("Text", source, "Weights");

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = source;
                if (RoleID == 1)
                {
                    btnDelete.Enabled = true;
                    btnCreate.Enabled = true;
                }
                if (products == null || products.Count() == 0)
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
                btnCreate.Text = "View cart";
                btnDelete.Text = "Add to cart";
            }
            //dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
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
                frmProductDetails.ShowDialog();
                ProductRepository = new ProductRepository();
                var products = ProductRepository.GetAllProducts();
                LoadProducts(products);
                //set focus product updated
                source.Position = source.Count - 1;
            }
            else if (mem.RoleId == 2)
            {
                frmCart frmCart = new frmCart(mem, Cart);
                this.Close();
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
                try
                {
                    frmProductDetails frmProductDetails = new frmProductDetails
                    {
                        Text = "Update product",
                        InsertOrUpdate = true,
                        Product = GetProduct(),
                        ProductRepository = ProductRepository,
                        RoleID = RoleID
                    };
                    frmProductDetails.ShowDialog();
                    ProductRepository = new ProductRepository();
                    var products = ProductRepository.GetAllProducts();
                    LoadProducts(products);
                    //Set focus product updated
                    source.Position = source.Count - 1;

                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error in frmProducts dgvProducts_CellDoubleClick: " + ex.Message);
                    MessageBox.Show(ex.Message, "Update product");
                }
            }
            if (RoleID == 2) //Member role
            {
                frmProductDetails frmProductDetails = new frmProductDetails
                {
                    Text = "View product",
                    InsertOrUpdate = true,
                    Product = GetProduct(),
                    ProductRepository = ProductRepository,
                    RoleID = RoleID
                };
                frmProductDetails.ShowDialog();
            }
        }

        private Product GetProduct()
        {
            Product? product = new Product();
            try
            {
                product = new Product
                {
                    ProductId = int.Parse(txtProductId.Text),
                    CategoryId = int.Parse(txtCategoryId.Text),
                    ProductName = txtProductName.Text,
                    Weights = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitInStock.Text)
                };
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error in frmProducts GetProduct: " + ex.Message);
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
                    if (MessageBox.Show(this, $"Are you sure to delete {product.ProductName}?", "Delete a product", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        ProductRepository = new ProductRepository();
                        ProductRepository.Delete(product);
                        var products = ProductRepository.GetAllProducts();
                        LoadProducts(products);
                    }

                }
                else if (mem.RoleId == 2)
                { //User role add to cart
                    var product = GetProduct();
                    ProductRepository = new ProductRepository();
                    product = ProductRepository.GetProductByID(product.ProductId);
                    //Check if item already in cart to increase or decrease
                    if (Cart.CheckProduct(product))
                    {
                        Cart.UpdateProduct(product);
                    }
                    else
                    {
                        Cart.AddProduct(product);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error in frmProducts btnDelete_Click: " + ex.Message);
                MessageBox.Show(ex.Message, "Delete a product");
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}