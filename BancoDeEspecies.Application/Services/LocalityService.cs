using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Locality;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ILocalityService : IBaseService<Locality, LocalityViewModel, CreateLocalityViewModel>
    {
    }

    public class LocalityService : BaseService<Locality, LocalityViewModel, CreateLocalityViewModel>, ILocalityService
    {
        public LocalityService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task<IEnumerable<LocalityViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<Locality>();
            var result = await repository.Get(includeProperties: "LocalityType");

            return result.Select(_mapper.Map<LocalityViewModel>);
        }
    }
}
