using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.StudyCollectMethod;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IStudyCollectMethodService : IBaseService<StudyCollectMethod, StudyCollectMethodViewModel, CreateStudyCollectMethodViewModel>
    {
    }

    public class StudyCollectMethodService : BaseService<StudyCollectMethod, StudyCollectMethodViewModel, CreateStudyCollectMethodViewModel>, IStudyCollectMethodService
    {
        public StudyCollectMethodService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
