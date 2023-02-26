using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.ReferenceType;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IReferenceTypeService : IBaseService<ReferenceType, ReferenceTypeViewModel, CreateReferenceTypeViewModel>
    {
    }

    public class ReferenceTypeService : BaseService<ReferenceType, ReferenceTypeViewModel, CreateReferenceTypeViewModel>, IReferenceTypeService
    {
        public ReferenceTypeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
