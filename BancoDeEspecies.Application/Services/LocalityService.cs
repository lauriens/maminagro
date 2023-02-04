using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ILocalityService : IBaseService<Locality, LocalityViewModel>
    {
    }

    public class LocalityService : BaseService<Locality, LocalityViewModel>, ILocalityService
    {
        public LocalityService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
