using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class CultureMap : Profile
    {
        public CultureMap()
        {
            CreateMap<Culture, CultureViewModel>().ReverseMap();
        }
    }
}
