using AutoMapper;
using BancoDeEspecies.Application.ViewModels.LandscapeMunicipality;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ILandscapeMunicipalityService
    {
        Task CreateAsync(CreateLandscapeMunicipalityViewModel landscapeMunicipalityViewModel);
        Task DeleteAsync(int landscapeId, int municipalityId);
    }

    public class LandscapeMunicipalityService : ILandscapeMunicipalityService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public LandscapeMunicipalityService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(CreateLandscapeMunicipalityViewModel landscapeMunicipalityViewModel)
        {
            var repository = _unitOfWork.GetBaseRepository<LandscapeMunicipality>();

            var entity = _mapper.Map<LandscapeMunicipality>(landscapeMunicipalityViewModel);
            repository.Insert(entity);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int landscapeId, int municipalityId)
        {
            var repository = _unitOfWork.GetBaseRepository<LandscapeMunicipality>();

            var entity = new LandscapeMunicipality
            {
                LandscapeId = landscapeId,
                MunicipalityId = municipalityId
            };

            repository.Delete(entity);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
