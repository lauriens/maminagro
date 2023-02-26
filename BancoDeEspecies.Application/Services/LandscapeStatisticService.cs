using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.LandscapeStatistic;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ILandscapeStatisticService : IBaseService<LandscapeStatistic, LandscapeStatisticViewModel, CreateLandscapeStatisticViewModel>
    {
    }

    public class LandscapeStatisticService : BaseService<LandscapeStatistic, LandscapeStatisticViewModel, CreateLandscapeStatisticViewModel>, ILandscapeStatisticService
    {
        public LandscapeStatisticService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
