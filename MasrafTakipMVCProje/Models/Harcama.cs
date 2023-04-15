using System.ComponentModel.DataAnnotations;

namespace MasrafTakipMVCProje.Models
{
    public class Harcama
    {
        [Key]
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public DateTime Tarihi { get; set; }
        public int FisNo { get; set; }
        public string Notlar { get; set; }
        public Durumu Durumu { get; set; }

        public virtual Personel? Personeller { get; set; }
        public virtual List<HarcamaDetay>? HarcamaDetaylari { get; set; }

    }

    public enum Durumu
    {
        [Display(Name = "Onay Bekliyor")]
        OnayBekliyor,
        [Display(Name = "Onaylandı")]
        Onaylandi,
        [Display(Name = "Reddedildi")]
        Reddedildi,
        [Display(Name = "Ödeme Yapıldı")]
        OdemeYapildi
    }
}
