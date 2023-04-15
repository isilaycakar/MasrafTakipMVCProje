using Microsoft.EntityFrameworkCore;
namespace MasrafTakipMVCProje.Models
{
    public class DataSeed
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<MasrafTakipContext>();
            context.Database.Migrate();

            if (!context.HarcamaTipleri.Any())
            {
                context.HarcamaTipleri.Add(new HarcamaTipi()
                {
                    Baslik = $"Yemek",
                    Aciklama = $"Yemek için açıklama satırı",
                });
                context.HarcamaTipleri.Add(new HarcamaTipi()
                {
                    Baslik = $"Vergi",
                    Aciklama = $"Vergi için açıklama satırı",
                });
                context.HarcamaTipleri.Add(new HarcamaTipi()
                {
                    Baslik = $"Ofis",
                    Aciklama = $"Ofis için açıklama satırı",
                });
                context.HarcamaTipleri.Add(new HarcamaTipi()
                {
                    Baslik = $"Yol Ücreti",
                    Aciklama = $"Yol için açıklama satırı",
                });
            }
        }
    }
}

