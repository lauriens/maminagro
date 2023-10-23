using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Uf;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IUfService : IBaseService<Uf, UfViewModel, CreateUfViewModel> 
    {
    }

    public class UfService : BaseService<Uf, UfViewModel, CreateUfViewModel>, IUfService
    {
        public UfService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task<IEnumerable<UfViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<Uf>();
            var result = await repository.Get(includeProperties: "Country");

            return result.Select(_mapper.Map<UfViewModel>);
        }
    }
}
