using AutoMapper;
using BancoDeEspecies.Application.ViewModels.ThreatDegree;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class ThreatDegreeMap : Profile
    {
        public ThreatDegreeMap()
        {
            CreateMap<ThreatDegree, ThreatDegreeViewModel>()
                .ForMember(td => td.Source, opt => opt.MapFrom(src => src.Source.ToString()));
            CreateMap<CreateThreatDegreeViewModel, ThreatDegree>();
            CreateMap<EditThreatDegreeViewModel, ThreatDegree>();
        }
    }
}
