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
    }
}
