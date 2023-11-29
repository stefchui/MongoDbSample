using MongoDB.Driver;
using MongoDbSample.Data.Models;

namespace MongoDbSample.Data.DataContexts
{
    public class CatalogContextSeed
    {
        public static void SeedProductSampleData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "Fundamentals of Wavelets",
                    Description = "Author: Goswami, Jaideva, Genre: signal_processing, Hardcover: 384 pages, Publisher: Wisley",
                    Price = 94.00M,
                    Category = "Book"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Integration of the Indian States",
                    Description = "Author: Menon, V P, Genre: history, Hardcover: 534 pages, Publisher: Orient Blackswan",
                    Price = 80.55M,
                    Category = "Book"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Slaughterhouse Five",
                    Description = "Author:Vonnegut, Kurt, Genre: fiction, Hardcover: 288 pages, Publisher: Random House",
                    Price = 12.23M,
                    Category = "Book"
                }
            };
        }
    }
}