
using BusinessObject.EntityModels;

namespace DataAccess.Repository;
public class ProductRepository : IProductRepositoy
{
    public void Delete(Product product) => ProductDAO.Instance.Delete(product);

    public IEnumerable<Product>? GetAllProducts() => ProductDAO.Instance.GetAllProducts();

    public Product? GetProductByID(int productId) => ProductDAO.Instance.Get(productId);

    public IEnumerable<Product>? GetProducts(string productName) => ProductDAO.Instance.GetProducts(productName);

    public void Insert(Product product) => ProductDAO.Instance.Insert(product);

    public void Update(Product product) => ProductDAO.Instance.Update(product);
}
