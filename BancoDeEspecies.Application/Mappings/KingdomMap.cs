using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class KingdomMap : Profile
    {
        public KingdomMap()
        {
            CreateMap<Kingdom, KingdomViewModel>().ReverseMap();
        }
    }
}
