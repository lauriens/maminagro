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

        public new async Task<IEnumerable<GenusViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<Genus>();
            var result = await repository.Get(includeProperties: "Family.Order.Class.Phylum.Kingdom.Domain");

            return result.Select(_mapper.Map<GenusViewModel>);
        }
    }
}
