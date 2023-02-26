using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Domain;
using BancoDeEspecies.DataAccess.UnitOfWork;

namespace BancoDeEspecies.Application.Services
{
    public interface IDomainService : IBaseService<Domain.Models.Domain, DomainViewModel, CreateDomainViewModel>
    {
    }

    public class DomainService : BaseService<Domain.Models.Domain, DomainViewModel, CreateDomainViewModel>, IDomainService
    {
        public DomainService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
