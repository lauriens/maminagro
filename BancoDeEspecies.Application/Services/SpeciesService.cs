using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Specie;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ISpeciesService : IBaseService<Specie, SpecieViewModel, CreateSpecieViewModel>
    {
    }

    public class SpeciesService : BaseService<Specie, SpecieViewModel, CreateSpecieViewModel>, ISpeciesService
    {
        public SpeciesService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task<SpecieViewModel> GetByIdAsync(int id)
        {
            var repository = _unitOfWork.GetBaseRepository<Specie>();
            var result = await repository.Get(s => s.Id == id, includeProperties: "Genus.Family.Order.Class.Phylum.Kingdom.Domain,ThreatDegrees.Uf,ThreatDegrees.Country");

            return _mapper.Map<SpecieViewModel>(result.FirstOrDefault());
        }
    }
}
