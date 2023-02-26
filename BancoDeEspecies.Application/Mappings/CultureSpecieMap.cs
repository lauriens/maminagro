using AutoMapper;
using BancoDeEspecies.Application.ViewModels.CultureSpecie;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class CultureSpecieMap : Profile
    {
        public CultureSpecieMap()
        {
            CreateMap<CultureSpecie, CultureSpecieViewModel>();
            CreateMap<CreateCultureSpecieViewModel, CultureSpecie>();
            CreateMap<EditCultureSpecieViewModel, CultureSpecie>();
        }
    }
}
