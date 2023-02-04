using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class ReferenceMap : Profile
    {
        public ReferenceMap()
        {
            CreateMap<Reference, ReferenceViewModel>().ReverseMap();
        }
    }
}
