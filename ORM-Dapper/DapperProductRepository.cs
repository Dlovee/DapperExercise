using System.Data;
using Dapper;

namespace ORM_Dapper;

public class DapperProductRepository : IProductRepository
{
    private readonly IDbConnection _conn;

    public DapperProductRepository(IDbConnection conn)
    {
        _conn = conn;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _conn.Query<Product>("SELECT * FROM products;");
    }

    public Product GetProduct(int id)
    {
        return _conn.QuerySingle<Product>("SELECT * FROM products WHERE ProductID = @id;", 
            new { id = id});
    }

    public void UpdateProduct(Product product)
    {
        _conn.Execute(@"UPDATE products 
                    SET Name = @Name, 
                        Price = @Price, 
                        CategoryID = @CategoryID, 
                        OnSale = @OnSale, 
                        StockLevel = @StockLevel 
                    WHERE ProductID = @ProductID", product);
    }


    public void CreateProduct(string name, double price, int categoryID)
    {
        throw new NotImplementedException();
    }
}