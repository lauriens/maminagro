using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class CultureSpecieMap : Profile
    {
        public CultureSpecieMap()
        {
            CreateMap<CultureSpecie, CultureSpecieViewModel>().ReverseMap();
        }
    }
}
