using AutoMapper;
using BancoDeEspecies.Application.ViewModels.ReferenceType;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class ReferenceTypeMap : Profile
    {
        public ReferenceTypeMap()
        {
            CreateMap<ReferenceType, ReferenceTypeViewModel>();
            CreateMap<CreateReferenceTypeViewModel, ReferenceType>();
        }
    }
}
