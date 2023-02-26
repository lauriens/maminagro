using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Specie;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class SpecieMap : Profile
    {
        public SpecieMap()
        {
            CreateMap<Specie, SpecieViewModel>();
            CreateMap<CreateSpecieViewModel, Specie>();
            CreateMap<EditSpecieViewModel, Specie>();
        }
    }
}
