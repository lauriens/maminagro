using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Reference;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IReferenceService : IBaseService<Reference, ReferenceViewModel, CreateReferenceViewModel>
    {
        Task<IEnumerable<ReferenceListViewModel>> GetReferenceListAsync();
    }

    public class ReferenceService : BaseService<Reference, ReferenceViewModel, CreateReferenceViewModel>, IReferenceService
    {
        public ReferenceService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task<IEnumerable<ReferenceViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<Reference>();
            var result = await repository.Get(includeProperties: "ReferenceType,StudyCollectMethods.MaterialDestination");

            return result.Select(_mapper.Map<ReferenceViewModel>);
        }

        public async Task<IEnumerable<ReferenceListViewModel>> GetReferenceListAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<Reference>();
            var result = await repository.Get();

            return result.Select(_mapper.Map<ReferenceListViewModel>);
        }
    }
}
