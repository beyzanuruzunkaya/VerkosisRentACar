using VerkosisRentACar.Models;

namespace VerkosisRentACar.DTOs
{
    public class KiralananAracDTO
    {
        public int Id { get; set; }
        public int AracId { get; set; }
        public int UyeId { get; set; }
        public DateTime BaslangicTarih { get; set; }
        public DateTime BitisTarih { get; set; }
    }
}
