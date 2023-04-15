using System.ComponentModel.DataAnnotations;

namespace MasrafTakipMVCProje.Models
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string Telefon { get; set; }
        public Gorevler Gorev { get; set; }

        public virtual List<Harcama> Harcamalar { get; set; } = new List<Harcama>();
    }
    public enum Gorevler
    {
        Personel, Yonetici
    }
}

