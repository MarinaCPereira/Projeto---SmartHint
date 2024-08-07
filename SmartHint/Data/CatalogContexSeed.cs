using MongoDB.Driver;
using SmartHint.Models;

namespace SmartHint.Data
{
    public class CatalogContexSeed
    {
        public static void SeedData(IMongoCollection<Comprador> compradorCollection)
        { 
            bool existcomprador = compradorCollection.Find(p => true).Any();
            if (!existcomprador)
            {
                compradorCollection.InsertManyAsync(GetMyCompradores());
            }
        }

        private static IEnumerable<Comprador> GetMyCompradores() 
        {
            return new List<Comprador>()
            {
                new Comprador()
                {


                }
            };
        }
    }
}
