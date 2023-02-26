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
    }
}
