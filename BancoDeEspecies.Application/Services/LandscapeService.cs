using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ILandscapeService : IBaseService<Landscape, LandscapeViewModel>
    {
    }

    public class LandscapeService : BaseService<Landscape, LandscapeViewModel>, ILandscapeService
    {
        public LandscapeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
