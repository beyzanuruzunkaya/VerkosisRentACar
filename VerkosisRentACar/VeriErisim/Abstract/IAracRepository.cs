using VerkosisRentACar.Models;

namespace VerkosisRentACar.VeriErisim.Abstract
{
    public interface IAracRepository : IGenericRepository<Arac>
    {
        List<Arac> GetByMarka(string marka);
    }
}
