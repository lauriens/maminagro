using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Anthrome;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class AnthromeMap : Profile
    {
        public AnthromeMap()
        {
            CreateMap<Anthrome, AnthromeViewModel>();
            CreateMap<CreateAnthromeViewModel, Anthrome>();
        }
    }
}
