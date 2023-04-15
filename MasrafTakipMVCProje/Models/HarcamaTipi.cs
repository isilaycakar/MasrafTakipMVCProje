using System.ComponentModel.DataAnnotations;

namespace MasrafTakipMVCProje.Models
{
    public class HarcamaTipi
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }

        public virtual List<HarcamaDetay> HarcamaDetaylari { get; set; } = new List<HarcamaDetay>();
    }
}
