using VerkosisRentACar.Models;

namespace VerkosisRentACar.VeriErisim.Abstract
{
    public interface IUyeRepository : IGenericRepository<Uye>
    {
        int GetIdByEMail(string EMail);
        bool IsUserExists(string EMail);
    }
}
