using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessObject.EntityModels;


namespace SalesWinApp {
    public partial class frmCart : Form {
        Member Member;
        Cart Cart;
        BindingSource source;

        public frmCart() {
            InitializeComponent();
        }

        public frmCart(Member member, Cart cart) {
            InitializeComponent();
            this.Member = member;
            this.Cart = cart;
            LoadProducts(Cart.list);
        }

        public Product GetProduct(int id) {
            foreach (Product product in Cart.list) {
                if (product.ProductId == id) { 
                    return product;
                }
            }
            return null;
        }

        public void ClearText() {
            txtProductId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtCategoryId.Text = string.Empty;
            txtUnitInStock.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }

        public void LoadProducts(IEnumerable<Product>? products) {
            try {
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
                if (products == null || products.Count() == 0) {
                    ClearText();
                    btnDelete.Enabled = false;
                    btnCheckout.Enabled = false;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Load product list");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var product = Cart.FindProduct(int.Parse(txtProductId.Text));
            if (product != null) { 
                Cart.DeleteProduct(product);
            }
            LoadProducts(Cart.list);
        }

        private void btnCheckout_Click(object sender, EventArgs e) {
            int id = CartDAO.Instance.AddOrder(Member);
            foreach (var item in Cart.list) {
                CartDAO.Instance.AddOrderDetail(id, item, 0);
            }
            Cart = null;
        }
    }
}
