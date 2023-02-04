using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;

namespace BancoDeEspecies.Application.Services
{
    public interface IDomainService : IBaseService<Domain.Models.Domain, DomainViewModel>
    {
    }

    public class DomainService : BaseService<Domain.Models.Domain, DomainViewModel>, IDomainService
    {
        public DomainService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
