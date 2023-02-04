using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IReferenceTypeService : IBaseService<ReferenceType, ReferenceTypeViewModel>
    {
    }

    public class ReferenceTypeService : BaseService<ReferenceType, ReferenceTypeViewModel>, IReferenceTypeService
    {
        public ReferenceTypeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
