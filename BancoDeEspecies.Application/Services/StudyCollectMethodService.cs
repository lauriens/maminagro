using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IStudyCollectMethodService : IBaseService<StudyCollectMethod, StudyCollectMethodViewModel>
    {
    }

    public class StudyCollectMethodService : BaseService<StudyCollectMethod, StudyCollectMethodViewModel>, IStudyCollectMethodService
    {
        public StudyCollectMethodService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
