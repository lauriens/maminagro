using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class AbundanceMap : Profile
    {
        public AbundanceMap()
        {
            CreateMap<Abundance, AbundanceViewModel>().ReverseMap();
        }
    }
}
