using BusinessObject.EntityModels;

namespace DataAccess.Repository;
public interface IProductRepositoy
{

    public Product? GetProductByID(int productId);
    public IEnumerable<Product>? GetProducts(string productName);
    public IEnumerable<Product>? GetAllProducts();
    public void Insert(Product product);
    public void Update(Product product);
    public void Delete(Product product);

}
