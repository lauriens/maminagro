using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class ColetaMethodMap : Profile
    {
        public ColetaMethodMap()
        {
            CreateMap<OccurrenceColetaMethod, ColetaMethodViewModel>().ReverseMap();
        }
    }
}
