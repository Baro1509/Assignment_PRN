using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.EntityModels;

namespace BusinessObject {
    public class Cart {
        public List<Product> list = new List<Product>();

        //Check if the product already exist in Cart
        public bool Exist(Product product) {
            foreach (Product p in list) {
                if (p.ProductId == product.ProductId) {
                    return true;
                }
            }
            return false;
        }

        public Product Get(int id) {
            foreach (Product p in list) {
                if (p.ProductId == id) {
                    return p;
                }
            }
            return null;
        }

        //Add Product to cart
        public void Add(Product product) {
            //If already exist -> increase quantity by 1
            if (Exist(product)) {
                Product p = Get(product.ProductId);
                p.UnitsInStock++;
            } 
            //If not exist -> add with quantity = 1 Note: UnitInStock is Quantity in Cart
            else {

            }
        }
    }
}
