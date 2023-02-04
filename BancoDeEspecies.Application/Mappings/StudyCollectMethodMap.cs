using AutoMapper;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class StudyCollectMethodMap : Profile
    {
        public StudyCollectMethodMap()
        {
            CreateMap<StudyCollectMethod, StudyCollectMethodViewModel>().ReverseMap();
        }
    }
}
