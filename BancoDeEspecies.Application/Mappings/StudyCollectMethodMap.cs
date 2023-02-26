using AutoMapper;
using BancoDeEspecies.Application.ViewModels.StudyCollectMethod;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class StudyCollectMethodMap : Profile
    {
        public StudyCollectMethodMap()
        {
            CreateMap<StudyCollectMethod, StudyCollectMethodViewModel>();
            CreateMap<CreateStudyCollectMethodViewModel, StudyCollectMethod>();
            CreateMap<EditStudyCollectMethodViewModel, StudyCollectMethod>();
        }
    }
}
