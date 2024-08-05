using Microsoft.EntityFrameworkCore;
using VerkosisRentACar.Models;

namespace VerkosisRentACar.Context
{
    public class RentACarDbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BEYZANUR;initial Catalog=AracKiralaDb;integrated Security=true;TrustServerCertificate=true;");
        }

        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Arac> Araclar { get; set; }
        public DbSet<KiralananArac> KiralananAraclar { get; set; }
    }
}
