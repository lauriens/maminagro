using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class FamilyMap : Profile
    {
        public FamilyMap()
        {
            CreateMap<Family, FamilyViewModel>().ReverseMap();
        }
    }
}
