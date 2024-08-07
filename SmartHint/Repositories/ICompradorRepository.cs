using SmartHint.Models;

namespace SmartHint.Repositories
{
    public interface ICompradorRepository
    {
        Task<IEnumerable<Comprador>> GetCompradores();
        Task<Comprador> GetComprador (string id);

        Task CreateComprador(Comprador comprador);
        Task<bool> UpdateComprador (Comprador comprador);
        Task<bool> DeleteComprador (string id);


    }
}
