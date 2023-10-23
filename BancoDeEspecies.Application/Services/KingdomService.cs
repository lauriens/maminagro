using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Kingdom;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IKingdomService : IBaseService<Kingdom, KingdomViewModel, CreateKingdomViewModel>
    {
    }

    public class KingdomService : BaseService<Kingdom, KingdomViewModel, CreateKingdomViewModel>, IKingdomService
    {
        public KingdomService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task<IEnumerable<KingdomViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<Kingdom>();
            var result = await repository.Get(includeProperties: "Domain");

            return result.Select(_mapper.Map<KingdomViewModel>);
        }
    }
}
