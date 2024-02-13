using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.LandscapeStatistic;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ILandscapeStatisticService : IBaseService<LandscapeStatistic, LandscapeStatisticViewModel, CreateLandscapeStatisticViewModel>
    {
        Task<IEnumerable<LandscapeStatisticViewModel>> GetLandscapeStatisticsAsync(int landscapeId);
    }

    public class LandscapeStatisticService : BaseService<LandscapeStatistic, LandscapeStatisticViewModel, CreateLandscapeStatisticViewModel>, ILandscapeStatisticService
    {
        public LandscapeStatisticService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public async Task<IEnumerable<LandscapeStatisticViewModel>> GetLandscapeStatisticsAsync(int landscapeId)
        {
            var repository = _unitOfWork.GetBaseRepository<LandscapeStatistic>();

            var result = await repository.Get(l => l.LandscapeId == landscapeId);

            return result.Select(_mapper.Map<LandscapeStatisticViewModel>);
        }
    }
}
