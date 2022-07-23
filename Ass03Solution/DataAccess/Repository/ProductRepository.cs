using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.EntityModels;


namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Product Get(int productId)=>ProductDAO.Instance.Get(productId);
        public void Add(Product product)=>ProductDAO.Instance.Add(product);
        public void Update(Product product)=>ProductDAO.Instance.Update(product);
        public void Delete(int productId)=>ProductDAO.Instance.Delete(productId);
        public IEnumerable<Product> GetProducts()=>ProductDAO.Instance.GetProducts();
    }
}
