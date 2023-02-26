using AutoMapper;
using BancoDeEspecies.Application.ViewModels.MaterialDestination;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class MaterialDestinationMap : Profile
    {
        public MaterialDestinationMap()
        {
            CreateMap<MaterialDestination, MaterialDestinationViewModel>();
            CreateMap<CreateMaterialDestinationViewModel, MaterialDestination>();
        }
    }
}
