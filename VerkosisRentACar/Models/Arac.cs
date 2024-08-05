namespace VerkosisRentACar.Models
{
    public class Arac
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int KoltukSayisi { get; set; }
        public string YakitTuru { get; set; }
        public bool VitesTuru { get; set; }
        public float Ucret { get; set; }
        public bool Uygun { get; set; } 
    }
}
