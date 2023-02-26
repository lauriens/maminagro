using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Class;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class ClassMap : Profile
    {
        public ClassMap()
        {
            CreateMap<Class, ClassViewModel>();
            CreateMap<CreateClassViewModel, Class>();
        }
    }
}
