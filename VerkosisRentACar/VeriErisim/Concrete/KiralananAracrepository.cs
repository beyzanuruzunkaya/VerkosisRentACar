using VerkosisRentACar.Context;
using VerkosisRentACar.Models;
using VerkosisRentACar.VeriErisim.Abstract;

namespace VerkosisRentACar.VeriErisim.Concrete
{
    public class KiralananAracrepository : GenericRepository<KiralananArac>, IKiralananAracRepository
    {
        public KiralananAracrepository(RentACarDbContext context) : base(context)
        {
        }
    }
}
