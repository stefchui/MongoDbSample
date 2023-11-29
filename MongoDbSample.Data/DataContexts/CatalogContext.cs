using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDbSample.Data.DataContexts.Contracts;
using MongoDbSample.Data.Models;

namespace MongoDbSample.Data.DataContexts
{
    public class CatalogContext : ICatalogContext
    {
        public readonly IConfiguration _configuration;
        public CatalogContext(IConfiguration configuration)
        {
            _configuration = configuration;
            var client = new MongoClient(_configuration["MongoDbSettings:ConnectionString"]);
            var database = client.GetDatabase(_configuration["MongoDbSettings:DbName"]);

            Products = database.GetCollection<Product>(_configuration["MongoDbSettings:CollectionName"]);
            CatalogContextSeed.SeedProductSampleData(Products);
        }

        public IMongoCollection<Product> Products { get; }
    }
}