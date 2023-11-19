using AutoMapper;
using BancoDeEspecies.Application.ViewModels.LandscapeLocality;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ILandscapeLocalityService
    {
        Task CreateAsync(CreateLandscapeLocalityViewModel landscapeLocalityViewModel);
        Task DeleteAsync(int landscapeId, int localityId);
    }

    public class LandscapeLocalityService : ILandscapeLocalityService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public LandscapeLocalityService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateAsync(CreateLandscapeLocalityViewModel landscapeLocalityViewModel)
        {
            var repository = _unitOfWork.GetBaseRepository<LandscapeLocality>();

            var entity = _mapper.Map<LandscapeLocality>(landscapeLocalityViewModel);
            repository.Insert(entity);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int landscapeId, int localityId)
        {
            var repository = _unitOfWork.GetBaseRepository<LandscapeLocality>();

            var entity = new LandscapeLocality
            {
                LandscapeId = landscapeId,
                LocalityId = localityId
            };

            repository.Delete(entity);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
