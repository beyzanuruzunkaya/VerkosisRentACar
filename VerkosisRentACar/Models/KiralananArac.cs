namespace VerkosisRentACar.Models
{
    public class KiralananArac
    {
        public int Id { get; set; }
        public int AracId { get; set; }
        public Arac Arac { get; set; }
        public int UyeId { get; set; }
        public Uye Uye { get; set; }
        public DateTime BaslangicTarih { get; set; }
        public DateTime BitisTarih { get; set; }
        
    }
}
