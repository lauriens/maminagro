using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Occurrence;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IOccurrenceService : IBaseService<Occurrence, OccurrenceViewModel, CreateOccurrenceViewModel>
    {
        new Task<int?> CreateAsync(CreateOccurrenceViewModel viewModel);
    }

    public class OccurrenceService : BaseService<Occurrence, OccurrenceViewModel, CreateOccurrenceViewModel>, IOccurrenceService
    {
        public OccurrenceService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task<IEnumerable<OccurrenceViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<Occurrence>();
            var result = await repository.Get(includeProperties: "OccurrenceColetaMethod,Reference.ReferenceType,Reference.StudyCollectMethods.MaterialDestination,Specie.Genus,ThreatDegree,Abundances,OccurrenceCultures.Culture,Locality.LocalityType");

            return result.Select(_mapper.Map<OccurrenceViewModel>);
        }

        public async new Task<int?> CreateAsync(CreateOccurrenceViewModel viewModel)
        {
            await base.CreateAsync(viewModel);

            var repository = _unitOfWork.GetBaseRepository<Occurrence>();
            var result = (await repository.Get(orderBy: l => l.OrderByDescending(e => e.Id))).FirstOrDefault();

            return result?.Id;
        }
    }
}
