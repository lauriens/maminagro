using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Reference;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class ReferenceMap : Profile
    {
        public ReferenceMap()
        {
            CreateMap<Reference, ReferenceViewModel>();
            CreateMap<Reference, ReferenceListViewModel>();
            CreateMap<CreateReferenceViewModel, Reference>();
            CreateMap<EditReferenceViewModel, Reference>();
        }
    }
}
