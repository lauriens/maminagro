using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Landscape;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ILandscapeService : IBaseService<Landscape, LandscapeViewModel, CreateLandscapeViewModel>
    {
    }

    public class LandscapeService : BaseService<Landscape, LandscapeViewModel, CreateLandscapeViewModel>, ILandscapeService
    {
        public LandscapeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
