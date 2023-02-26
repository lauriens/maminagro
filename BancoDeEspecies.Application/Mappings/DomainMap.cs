using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Domain;

namespace BancoDeEspecies.Application.Mappings
{
    public class DomainMap : Profile
    {
        public DomainMap()
        {
            CreateMap<Domain.Models.Domain, DomainViewModel>();
            CreateMap<CreateDomainViewModel, Domain.Models.Domain>();
        }
    }
}
