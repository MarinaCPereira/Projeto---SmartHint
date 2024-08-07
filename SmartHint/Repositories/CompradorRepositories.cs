using MongoDB.Driver;
using SmartHint.Data;
using SmartHint.Models;

namespace SmartHint.Repositories
{
    public class CompradorRepositories
    {
        public class CompradorRepository : ICompradorRepository
        {
            private readonly ICatalogContext _context;
            public CompradorRepository(ICatalogContext context) 
            {
                _context = context;
            }

            public async Task CreateComprador(Comprador comprador)
            {
                await _context.Compradores.InsertOneAsync(comprador);
            }

            public async Task<bool> DeleteComprador(string id)
            {
                FilterDefinition<Comprador> filter = Builders<Comprador>.Filter.Eq(p => p.Id, id);

                DeleteResult deleteResult = await _context.Compradores.DeleteOneAsync(filter);

                return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;
            }

            public async Task<IEnumerable<Comprador>> GetCompradores()
            {
                return await _context.Compradores.Find(p => true).ToListAsync();
            }

            public async Task<Comprador> GetComprador(string id)
            {
                return await _context.Compradores.Find(p => p.Id == id).FirstOrDefaultAsync();
            }

            public async Task<bool> UpdateComprador(Comprador comprador)
            {
                var updateResult = await _context.Compradores.ReplaceOneAsync(
                    filter: g => g.Id == comprador.Id, replacement: comprador);

                return updateResult.IsAcknowledged
                && updateResult.ModifiedCount > 0;
            }
        }
    }
}
