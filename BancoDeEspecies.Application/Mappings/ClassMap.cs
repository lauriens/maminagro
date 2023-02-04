using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class ClassMap : Profile
    {
        public ClassMap()
        {
            CreateMap<Class, ClassViewModel>().ReverseMap();
        }
    }
}
