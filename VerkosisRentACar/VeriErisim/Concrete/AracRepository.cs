using VerkosisRentACar.Context;
using VerkosisRentACar.Models;
using VerkosisRentACar.VeriErisim.Abstract;

namespace VerkosisRentACar.VeriErisim.Concrete
{
    public class AracRepository : GenericRepository<Arac>, IAracRepository
    {
        public AracRepository(RentACarDbContext context) : base(context)
        {
        }

        public List<Arac> GetByMarka(string marka)
        {
            List<Arac> araclar = _context.Araclar.Where(arac => arac.Marka == marka).ToList();
            return araclar;
        }
        public List<Arac> GetByModel(string model)
        {
            List<Arac> araclar = _context.Araclar.Where(arac => arac.Model == model).ToList();
            return araclar;
        }
        public List<Arac> GetByKoltukSayisi(int koltuk_sayisi)
        {
            List<Arac> araclar = _context.Araclar.Where(arac => arac.KoltukSayisi == koltuk_sayisi).ToList();
            return araclar;
        }
        public List<Arac> GetByYakitTuru(string yakit_turu)
        {
            List<Arac> araclar = _context.Araclar.Where(arac => arac.YakitTuru == yakit_turu).ToList();
            return araclar;
        }
        public List<Arac> GetByVitesTuru(bool vites_turu)
        {
            List<Arac> araclar = _context.Araclar.Where(arac => arac.VitesTuru == vites_turu).ToList();
            return araclar;
        }
    }
}
