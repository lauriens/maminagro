using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Agroecosystem;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class AgroecosystemMap : Profile
    {
        public AgroecosystemMap()
        {
            CreateMap<Agroecosystem, AgroecosystemViewModel>();
            CreateMap<CreateAgroecosystemViewModel, Agroecosystem>();
        }
    }
}
