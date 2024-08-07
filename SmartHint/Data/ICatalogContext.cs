using MongoDB.Driver;
using SmartHint.Models;

namespace SmartHint.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Comprador> Compradores { get; }

    }
}
