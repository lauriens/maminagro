using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Family;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class FamilyMap : Profile
    {
        public FamilyMap()
        {
            CreateMap<Family, FamilyViewModel>();
            CreateMap<CreateFamilyViewModel, Family>();
            CreateMap<EditFamilyViewModel, Family>();
        }
    }
}
