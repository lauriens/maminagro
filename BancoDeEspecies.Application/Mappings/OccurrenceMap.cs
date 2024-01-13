using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Occurrence;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class OccurrenceMap : Profile
    {
        public OccurrenceMap()
        {
            CreateMap<Occurrence, OccurrenceViewModel>()
                .ForMember(o => o.OccurrenceType, opt => opt.MapFrom(src => src.OccurrenceType.ToString()));
            CreateMap<Occurrence, OccurrenceForOccurrenceCultureViewModel>()
                .ForMember(o => o.OccurrenceType, opt => opt.MapFrom(src => src.OccurrenceType.ToString()));
            CreateMap<CreateOccurrenceViewModel, Occurrence>();
            CreateMap<EditOccurrenceViewModel, Occurrence>();
        }
    }
}
