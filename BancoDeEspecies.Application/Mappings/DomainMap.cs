using AutoMapper;
using BancoDeEspecies.Application.ViewModels;

namespace BancoDeEspecies.Application.Mappings
{
    public class DomainMap : Profile
    {
        public DomainMap()
        {
            CreateMap<Domain.Models.Domain, DomainViewModel>().ReverseMap();
        }
    }
}
