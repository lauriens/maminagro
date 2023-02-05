using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class ReviewMap : Profile
    {
        public ReviewMap()
        {
            CreateMap<Review, ReviewViewModel>().ReverseMap();
        }
    }
}
