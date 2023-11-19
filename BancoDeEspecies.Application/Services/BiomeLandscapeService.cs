using AutoMapper;
using BancoDeEspecies.Application.ViewModels.BiomeLandscape;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IBiomeLandscapeService
    {
        Task CreateAsync(CreateBiomeLandscapeViewModel biomeLandscapeViewModel);
        Task DeleteAsync(int biomeId, int landscapeId);
    }

    public class BiomeLandscapeService : IBiomeLandscapeService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public BiomeLandscapeService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(CreateBiomeLandscapeViewModel biomeLandscapeViewModel)
        {
            var repository = _unitOfWork.GetBaseRepository<BiomeLandscape>();

            var entity = _mapper.Map<BiomeLandscape>(biomeLandscapeViewModel);
            repository.Insert(entity);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int biomeId, int landscapeId)
        {
            var repository = _unitOfWork.GetBaseRepository<BiomeLandscape>();

            var entity = new BiomeLandscape
            {
                BiomeId = biomeId,
                LandscapeId = landscapeId
            };

            repository.Delete(entity);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
