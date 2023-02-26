using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Locality;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class LocalityMap : Profile
    {
        public LocalityMap()
        {
            CreateMap<Locality, LocalityViewModel>();
            CreateMap<CreateLocalityViewModel, Locality>();
            CreateMap<EditLocalityViewModel, Locality>();
        }
    }
}
