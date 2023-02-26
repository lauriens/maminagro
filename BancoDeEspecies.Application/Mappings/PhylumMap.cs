using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Phylum;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class PhylumMap : Profile
    {
        public PhylumMap()
        {
            CreateMap<Phylum, PhylumViewModel>();
            CreateMap<CreatePhylumViewModel, Phylum>();
            CreateMap<EditPhylumViewModel, Phylum>();
        }
    }
}
