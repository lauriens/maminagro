using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class UfMap : Profile
    {
        public UfMap()
        {
            CreateMap<Uf, UfViewModel>().ReverseMap();
        }
    }
}
