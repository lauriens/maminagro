using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Kingdom;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class KingdomMap : Profile
    {
        public KingdomMap()
        {
            CreateMap<Kingdom, KingdomViewModel>();
            CreateMap<CreateKingdomViewModel, Kingdom>();
            CreateMap<EditKingdomViewModel, Kingdom>();
        }
    }
}
