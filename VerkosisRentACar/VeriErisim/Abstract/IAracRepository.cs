using VerkosisRentACar.Models;

namespace VerkosisRentACar.VeriErisim.Abstract
{
    public interface IAracRepository : IGenericRepository<Arac>
    {
        List<Arac> GetByMarka(string marka);
        List<Arac> GetByModel(string model);
        List<Arac> GetByKoltukSayisi(int koltuk_sayisi);
        List<Arac> GetByYakitTuru(string yakit_turu);
        List<Arac> GetByVitesTuru (bool vites_turu);
    }
}
