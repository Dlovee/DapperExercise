namespace ORM_Dapper;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
    public Product GetProduct(int id);
    public void UpdateProduct(Product product);
    void CreateProduct(string name, double price, int categoryID);
}