using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.OccurrenceCulture;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;
using System.Linq.Expressions;

namespace BancoDeEspecies.Application.Services
{
    public interface IOccurrenceCultureService : IBaseService<OccurrenceCulture, OccurrenceCultureForOccurrenceViewModel, CreateOccurrenceCultureViewModel>
    {
        Task<IEnumerable<OccurrenceCultureForCultureViewModel>> GetFilteredOccurrenceCultures(int? cultureId, int? occurrenceId);
    }

    public class OccurrenceCultureService : BaseService<OccurrenceCulture, OccurrenceCultureForOccurrenceViewModel, CreateOccurrenceCultureViewModel>, IOccurrenceCultureService
    {
        public OccurrenceCultureService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public async Task<IEnumerable<OccurrenceCultureForCultureViewModel>> GetFilteredOccurrenceCultures(int? cultureId, int? occurrenceId)
        {
            var repository = _unitOfWork.GetBaseRepository<OccurrenceCulture>();

            Expression<Func<OccurrenceCulture, bool>> filter = c => (cultureId == null || c.CultureId == cultureId) && (occurrenceId == null || c.OccurrenceId == occurrenceId);

            var result = await repository.Get(filter);

            return result.Select(_mapper.Map<OccurrenceCultureForCultureViewModel>);
        }
    }
}
