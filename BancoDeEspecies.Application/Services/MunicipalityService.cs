using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Application.ViewModels.Municipality;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IMunicipalityService : IBaseService<Municipality, MunicipalityViewModel, CreateMunicipalityViewModel>
    {
    }

    public class MunicipalityService : BaseService<Municipality, MunicipalityViewModel, CreateMunicipalityViewModel>, IMunicipalityService
    {
        public MunicipalityService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        
    }
}
