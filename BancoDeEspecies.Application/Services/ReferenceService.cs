using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Reference;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IReferenceService : IBaseService<Reference, ReferenceViewModel, CreateReferenceViewModel>
    {
    }

    public class ReferenceService : BaseService<Reference, ReferenceViewModel, CreateReferenceViewModel>, IReferenceService
    {
        public ReferenceService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
