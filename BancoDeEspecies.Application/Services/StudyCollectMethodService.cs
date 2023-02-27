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

        public new async Task CreateAsync(CreateStudyCollectMethodViewModel viewModel)
        {
            viewModel.CollectStartDate = viewModel.CollectStartDate?.ToUniversalTime();
            viewModel.CollectEndDate = viewModel.CollectEndDate?.ToUniversalTime();

            await base.CreateAsync(viewModel);
        }
    }
}
