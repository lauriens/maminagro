using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class PhylumMap : Profile
    {
        public PhylumMap()
        {
            CreateMap<Phylum, PhylumViewModel>().ReverseMap();
        }
    }
}
