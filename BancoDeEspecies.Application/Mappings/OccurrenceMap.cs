using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Occurrence;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class OccurrenceMap : Profile
    {
        public OccurrenceMap()
        {
            CreateMap<Occurrence, OccurrenceViewModel>();
            CreateMap<CreateOccurrenceViewModel, Occurrence>();
            CreateMap<EditOccurrenceViewModel, Occurrence>();
        }
    }
}
