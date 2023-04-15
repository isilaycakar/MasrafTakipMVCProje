using Microsoft.EntityFrameworkCore;

namespace MasrafTakipMVCProje.Models
{
    public class MasrafTakipContext : DbContext
    {
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Harcama> Harcamalar { get; set; }
        public DbSet<HarcamaDetay> HarcamaDetaylari { get; set; }

        public DbSet<HarcamaTipi> HarcamaTipleri { get; set; }

        public MasrafTakipContext(DbContextOptions<MasrafTakipContext> options) : base(options)
        {
            //Database.Migrate();
        }
    }
}
