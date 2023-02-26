using AutoMapper;
using BancoDeEspecies.Application.ViewModels.SampleAreaType;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class SampleAreaTypeMap : Profile
    {
        public SampleAreaTypeMap()
        {
            CreateMap<SampleAreaType, SampleAreaTypeViewModel>();
            CreateMap<CreateSampleAreaTypeViewModel, SampleAreaType>();
        }
    }
}
