using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IMaterialDestinationService : IBaseService<MaterialDestination, MaterialDestinationViewModel>
    {
    }

    public class MaterialDestinationService : BaseService<MaterialDestination, MaterialDestinationViewModel>, IMaterialDestinationService
    {
        public MaterialDestinationService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
