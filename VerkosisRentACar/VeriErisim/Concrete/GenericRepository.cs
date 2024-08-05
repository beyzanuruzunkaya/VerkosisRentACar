using VerkosisRentACar.Context;
using VerkosisRentACar.VeriErisim.Abstract;

namespace VerkosisRentACar.VeriErisim.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly RentACarDbContext _context;

        public GenericRepository(RentACarDbContext context)
        {
            _context = context;
        }

        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public T GetByID(int id)
        {
            T value = _context.Set<T>().Find(id);
            return value;
        }

        public List<T> GetList()
        {
            List<T> values = _context.Set<T>().ToList();
            return values;
        }

        public void Insert(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
