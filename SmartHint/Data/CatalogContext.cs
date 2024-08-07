using Microsoft.Win32;
using MongoDB.Driver;
using SmartHint.Models;

namespace SmartHint.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration) 
        {
            var client = new MongoClient(configuration.GetValue<string>
                ("DatabaseSettings:ConnectionString"));

            var database = client.GetDatabase(configuration.GetValue<string>
                ("DatabaseSettings:DatabaseName"));

            Compradores = database.GetCollection<Comprador>(configuration.GetValue<string>
                ("DatabaseSettings:CollectionName"));

            CatalogContexSeed.SeedData(Compradores);

        }
        public IMongoCollection<Comprador> Compradores { get; }
    }
}
