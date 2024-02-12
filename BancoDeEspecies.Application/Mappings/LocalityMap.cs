using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Locality;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class LocalityMap : Profile
    {
        public LocalityMap()
        {
            CreateMap<Locality, LocalityViewModel>()
                .ForMember(l => l.SampleAreaType, opt => opt.MapFrom(src => src.LocalityType));
            CreateMap<CreateLocalityViewModel, Locality>()
                .ForMember(l => l.TypeId, opt => opt.MapFrom(src => src.SampleAreaTypeId));
            CreateMap<EditLocalityViewModel, Locality>()
                .ForMember(l => l.TypeId, opt => opt.MapFrom(src => src.SampleAreaTypeId));
        }
    }
}
