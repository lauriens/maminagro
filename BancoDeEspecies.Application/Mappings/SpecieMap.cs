using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class SpecieMap : Profile
    {
        public SpecieMap()
        {
            CreateMap<Specie, SpeciesViewModel>().ReverseMap();
        }
    }
}
