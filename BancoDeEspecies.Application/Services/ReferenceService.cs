using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IReferenceService : IBaseService<Reference, ReferenceViewModel>
    {
    }

    public class ReferenceService : BaseService<Reference, ReferenceViewModel>, IReferenceService
    {
        public ReferenceService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
