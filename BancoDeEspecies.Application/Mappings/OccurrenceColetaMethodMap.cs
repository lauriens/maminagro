using AutoMapper;
using BancoDeEspecies.Application.ViewModels.OccurrenceColetaMethod;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class OccurrenceColetaMethodMap : Profile
    {
        public OccurrenceColetaMethodMap()
        {
            CreateMap<OccurrenceColetaMethod, OccurrenceColetaMethodViewModel>();
            CreateMap<CreateOccurrenceColetaMethodViewModel, OccurrenceColetaMethod>();
        }
    }
}
