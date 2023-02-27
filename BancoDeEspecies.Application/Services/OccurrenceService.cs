using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Occurrence;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IOccurrenceService : IBaseService<Occurrence, OccurrenceViewModel, CreateOccurrenceViewModel>
    {
    }

    public class OccurrenceService : BaseService<Occurrence, OccurrenceViewModel, CreateOccurrenceViewModel>, IOccurrenceService
    {
        public OccurrenceService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task<IEnumerable<OccurrenceViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<Occurrence>();
            var result = await repository.Get(includeProperties: "OccurenceColetaMethod,Reference,Specie,ThreatDegree,OccurrenceCultures,Locality");

            return result.Select(_mapper.Map<OccurrenceViewModel>);
        }
    }
}
