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

    public void CreateProduct(string name, double price, int categoryID)
    {
        throw new NotImplementedException();
    }
}