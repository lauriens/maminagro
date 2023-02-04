using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class ThreatDegreeMap : Profile
    {
        public ThreatDegreeMap()
        {
            CreateMap<ThreatDegree, ThreatDegreeViewModel>().ReverseMap();
        }
    }
}
