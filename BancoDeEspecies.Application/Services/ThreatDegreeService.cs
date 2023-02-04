using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IThreatDegreeService : IBaseService<ThreatDegree, ThreatDegreeViewModel>
    {
    }

    public class ThreatDegreeService : BaseService<ThreatDegree, ThreatDegreeViewModel>, IThreatDegreeService
    {
        public ThreatDegreeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
