using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ILocationTypeService : IBaseService<LocalityType, LocationTypeViewModel>
    {
    }

    public class LocationTypeService : BaseService<LocalityType, LocationTypeViewModel>, ILocationTypeService
    {
        public LocationTypeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
