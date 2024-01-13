using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Culture;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class CultureMap : Profile
    {
        public CultureMap()
        {
            CreateMap<Culture, CultureViewModel>()
                .ForMember(c => c.TimeSincePlantingUnit, opt => opt.MapFrom(src => src.TimeSincePlantingUnit.ToString()));
            CreateMap<Culture, CultureForOccurrenceCultureViewModel>()
                .ForMember(c => c.TimeSincePlantingUnit, opt => opt.MapFrom(src => src.TimeSincePlantingUnit.ToString()));
            CreateMap<CreateCultureViewModel, Culture>();
            CreateMap<EditCultureViewModel, Culture>();
        }
    }
}
