using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Abundance;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;
using System.Linq.Expressions;

namespace BancoDeEspecies.Application.Services
{
    public interface IAbundanceService : IBaseService<Abundance, AbundanceViewModel, CreateAbundanceViewModel>
    {
        Task<IEnumerable<AbundanceViewModel>> GetFilteredAbundances(int? occurrenceId, int? landscapeId);
    }

    public class AbundanceService : BaseService<Abundance, AbundanceViewModel, CreateAbundanceViewModel>, IAbundanceService
    {
        public AbundanceService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public async Task<IEnumerable<AbundanceViewModel>> GetFilteredAbundances(int? occurrenceId, int? landscapeId)
        {
            var repository = _unitOfWork.GetBaseRepository<Abundance>();
            Expression<Func<Abundance, bool>> filter = c => (landscapeId == null || c.LandscapeId == landscapeId) && (occurrenceId == null || c.OccurrenceId == occurrenceId);

            var result = await repository.Get(filter);

            return result.Select(_mapper.Map<AbundanceViewModel>);
        }
    }
}
