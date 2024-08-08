using AutoMapper;
using VerkosisRentACar.DTOs;
using VerkosisRentACar.Models;

namespace VerkosisRentACar.Mapping
{
    public class RentMapping : Profile
    {
        public RentMapping() {

            CreateMap<KiralananArac, KiralananAracDTO>().ReverseMap();

        }
    }
}
