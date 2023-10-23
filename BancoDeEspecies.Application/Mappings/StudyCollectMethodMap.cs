using AutoMapper;
using BancoDeEspecies.Application.ViewModels.StudyCollectMethod;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class StudyCollectMethodMap : Profile
    {
        public StudyCollectMethodMap()
        {
            CreateMap<StudyCollectMethod, StudyCollectMethodViewModel>()
                .ForMember(stm => stm.SampleDrawing, opt => opt.MapFrom(src => src.SampleDrawing.ToString()));
            CreateMap<CreateStudyCollectMethodViewModel, StudyCollectMethod>();
            CreateMap<EditStudyCollectMethodViewModel, StudyCollectMethod>();
        }
    }
}
