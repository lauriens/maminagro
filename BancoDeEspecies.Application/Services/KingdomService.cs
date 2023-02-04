using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IKingdomService : IBaseService<Kingdom, KingdomViewModel>
    {
    }

    public class KingdomService : BaseService<Kingdom, KingdomViewModel>, IKingdomService
    {
        public KingdomService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
