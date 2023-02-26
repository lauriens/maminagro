using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Genus;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class GenusMap : Profile
    {
        public GenusMap()
        {
            CreateMap<Genus, GenusViewModel>();
            CreateMap<CreateGenusViewModel, Genus>();
            CreateMap<EditGenusViewModel, Genus>();
        }
    }
}
