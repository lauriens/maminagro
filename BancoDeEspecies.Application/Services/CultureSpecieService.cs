using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.CultureSpecie;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ICultureSpecieService : IBaseService<CultureSpecie, CultureSpecieViewModel, CreateCultureSpecieViewModel>
    {
    }

    public class CultureSpecieService : BaseService<CultureSpecie, CultureSpecieViewModel, CreateCultureSpecieViewModel>, ICultureSpecieService
    {
        public CultureSpecieService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task<CultureSpecieViewModel> GetByIdAsync(int id)
        {
            var repository = _unitOfWork.GetBaseRepository<CultureSpecie>();
            var result = await repository.Get(c => c.Id == id, includeProperties: "Genus.Family.Order.Class.Phylum.Kingdom.Domain");

            return _mapper.Map<CultureSpecieViewModel>(result.FirstOrDefault());
        }

        public new async Task<IEnumerable<CultureSpecieViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<CultureSpecie>();
            var result = await repository.Get(includeProperties: "Genus");

            return result.Select(_mapper.Map<CultureSpecieViewModel>);
        }
    }
}
