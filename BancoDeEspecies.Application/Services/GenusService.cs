using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Genus;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IGenusService : IBaseService<Genus, GenusViewModel, CreateGenusViewModel>
    {
    }

    public class GenusService : BaseService<Genus, GenusViewModel, CreateGenusViewModel>, IGenusService
    {
        public GenusService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task<GenusViewModel> GetByIdAsync(int id)
        {
            var repository = _unitOfWork.GetBaseRepository<Genus>();
            var result = await repository.Get(g => g.Id == id, includeProperties: "Family.Order.Class.Phylum.Kingdom.Domain");

            return _mapper.Map<GenusViewModel>(result.FirstOrDefault());
        }
    }
}
