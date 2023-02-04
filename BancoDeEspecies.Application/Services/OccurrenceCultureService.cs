using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IOccurrenceCultureService : IBaseService<OccurrenceCulture, OccurrenceCultureViewModel>
    {
    }

    public class OccurrenceCultureService : BaseService<OccurrenceCulture, OccurrenceCultureViewModel>, IOccurrenceCultureService
    {
        public OccurrenceCultureService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
