using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.LandscapeMunicipality;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ILandscapeMunicipalityService : IBaseService<LandscapeMunicipality, CreateLandscapeMunicipalityViewModel, CreateLandscapeMunicipalityViewModel>
    {
    }

    public class LandscapeMunicipalityService : BaseService<LandscapeMunicipality, CreateLandscapeMunicipalityViewModel, CreateLandscapeMunicipalityViewModel>, ILandscapeMunicipalityService
    {
        public LandscapeMunicipalityService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        { }
        public new async Task<IEnumerable<CreateLandscapeMunicipalityViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public new async Task<CreateLandscapeMunicipalityViewModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
