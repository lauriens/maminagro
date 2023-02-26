using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Uf;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class UfMap : Profile
    {
        public UfMap()
        {
            CreateMap<Uf, UfViewModel>();
            CreateMap<CreateUfViewModel, Uf>();
            CreateMap<EditUfViewModel, Uf>();
        }
    }
}
