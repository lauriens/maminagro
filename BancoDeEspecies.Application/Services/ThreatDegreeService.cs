using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.ThreatDegree;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IThreatDegreeService : IBaseService<ThreatDegree, ThreatDegreeViewModel, CreateThreatDegreeViewModel>
    {
    }

    public class ThreatDegreeService : BaseService<ThreatDegree, ThreatDegreeViewModel, CreateThreatDegreeViewModel>, IThreatDegreeService
    {
        public ThreatDegreeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task CreateAsync(CreateThreatDegreeViewModel viewModel)
        {
            viewModel.ResolutionDate = viewModel.ResolutionDate?.ToUniversalTime();

            await base.CreateAsync(viewModel);
        }

        public new async Task<IEnumerable<ThreatDegreeViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<ThreatDegree>();
            var result = await repository.Get(includeProperties: "Specie,Uf,Country");

            return result.Select(_mapper.Map<ThreatDegreeViewModel>);
        }
    }
}
