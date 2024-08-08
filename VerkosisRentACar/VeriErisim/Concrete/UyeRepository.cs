using VerkosisRentACar.Context;
using VerkosisRentACar.Models;
using VerkosisRentACar.VeriErisim.Abstract;

namespace VerkosisRentACar.VeriErisim.Concrete
{
    public class UyeRepository : GenericRepository<Uye>, IUyeRepository
    {
        public UyeRepository(RentACarDbContext context) : base(context)
        {
        }

        public int GetIdByEMail(string EMail)
        {
            Uye uye = _context.Uyeler.Where(x => x.EMail == EMail).FirstOrDefault();
            return uye.Id;
        }

        public bool IsUserExists(string EMail)
        {
            Uye uye = _context.Uyeler.Where(x => x.EMail == EMail).FirstOrDefault();
            return uye != null;
        }
    }
}
