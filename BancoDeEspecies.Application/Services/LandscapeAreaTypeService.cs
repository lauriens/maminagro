using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ILandscapeAreaTypeService : IBaseService<LandscapeAreaType, LandscapeAreaTypeViewModel>
    {
    }

    public class LandscapeAreaTypeService : BaseService<LandscapeAreaType, LandscapeAreaTypeViewModel>, ILandscapeAreaTypeService
    {
        public LandscapeAreaTypeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
