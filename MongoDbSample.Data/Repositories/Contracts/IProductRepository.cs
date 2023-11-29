using MongoDbSample.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbSample.Data.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IList<Product>> GetProducts();
        Task<Product> GetProduct(string id);
        Task<IList<Product>> GetProductByName(string name);
        Task<IList<Product>> GetProductByCategory(string categoryName);

        Task CreateProductAsync(Product product);
        Task<bool> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(string id);
    }
}
