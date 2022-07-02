
using BusinessObject.EntityModels;

namespace DataAccess.Repository;
public class ProductRepository : IProductRepositoy
{
    public void Delete(Product product)
    {

    }

    public IEnumerable<Product> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public Product GetProductByID(int productId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetProducts(string productName)
    {
        throw new NotImplementedException();
    }

    public void Insert(Product product)
    {
        throw new NotImplementedException();
    }

    public void Update(Product product)
    {
        throw new NotImplementedException();
    }
}
