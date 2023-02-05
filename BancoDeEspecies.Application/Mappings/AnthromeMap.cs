using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class AnthromeMap : Profile
    {
        public AnthromeMap()
        {
            CreateMap<Anthrome, AnthromeViewModel>().ReverseMap();
        }
    }
}
