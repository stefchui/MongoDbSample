using MongoDB.Driver;
using MongoDbSample.Data.Models;

namespace MongoDbSample.Data.DataContexts.Contracts
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
