using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.EntityModels;


namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        public Product Get(int productId);
        public void Update(Product product);
        public void Delete(int productId);
        public IEnumerable<Product>GetProducts();
        public void Add(Product product);
    }
}
