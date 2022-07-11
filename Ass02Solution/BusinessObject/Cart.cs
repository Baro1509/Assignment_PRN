using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.EntityModels;
public class Cart {
    public Member Member { get; set; }
    public List<Product> list { get; set; }
    
    public Cart() { }

    public Cart(Member member) { 
        Member = member;
        list = new List<Product>();
    }

    public void AddProduct(Product product) {
        list.Add(product);
    }

    public void DeleteProduct(Product product) { 
        list.Remove(product);
    }

    public bool CheckProduct(Product product) {
        bool check = false;
        foreach (var item in list) {
            if (item.ProductId == product.ProductId) {
                check = true;
                break;
            }
        }
        return check;
    }

    public Product FindProduct(int id) {
        foreach (var item in list) {
            if (item.ProductId == id) { 
                return item;
            }
        }
        return null;
    }

    public void UpdateProduct(Product product) { 
        product = FindProduct(product.ProductId);
        product.UnitsInStock++;
    }
}
