using AutoMapper;
using BancoDeEspecies.Application.ViewModels.User;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class UserMap : Profile
    {
        public UserMap()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<CreateUserViewModel, User>();
        }
    }
}
