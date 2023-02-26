using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.OccurrenceCulture;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IOccurrenceCultureService : IBaseService<OccurrenceCulture, OccurrenceCultureViewModel, CreateOccurrenceCultureViewModel>
    {
    }

    public class OccurrenceCultureService : BaseService<OccurrenceCulture, OccurrenceCultureViewModel, CreateOccurrenceCultureViewModel>, IOccurrenceCultureService
    {
        public OccurrenceCultureService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
