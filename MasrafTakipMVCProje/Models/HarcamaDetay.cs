using System.ComponentModel.DataAnnotations;

namespace MasrafTakipMVCProje.Models
{
    public class HarcamaDetay
    {
        [Key]
        public int Id { get; set; }
        public int HarcamaId { get; set; }
        public int HarcamaTipiId { get; set; }
        public string Aciklama { get; set; }
        public int Tutar { get; set; }

        public virtual HarcamaTipi? HarcamaTipleri { get; set; }
        public virtual Harcama? Harcama { get; set; }
    }
}
