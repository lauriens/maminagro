using AutoMapper;
using BancoDeEspecies.Application.ViewModels.OccurrenceCulture;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class OccurrenceCultureMap : Profile
    {
        public OccurrenceCultureMap()
        {
            CreateMap<OccurrenceCulture, OccurrenceCultureForOccurrenceViewModel>();
            CreateMap<OccurrenceCulture, OccurrenceCultureForCultureViewModel>();
            CreateMap<CreateOccurrenceCultureViewModel, OccurrenceCulture>();
        }
    }
}
