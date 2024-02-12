using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Landscape;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ILandscapeService : IBaseService<Landscape, LandscapeViewModel, CreateLandscapeViewModel>
    {
        new Task<int?> CreateAsync(CreateLandscapeViewModel viewModel);
    }

    public class LandscapeService : BaseService<Landscape, LandscapeViewModel, CreateLandscapeViewModel>, ILandscapeService
    {
        public LandscapeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task<IEnumerable<LandscapeViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<Landscape>();
            var result = await repository.Get(includeProperties: "Anthrome,Agroecosystem,LandscapeMunicipalities.Municipality.Uf,SampleAreaType,Reference.ReferenceType,Reference.StudyCollectMethods.MaterialDestination,Abundances,BiomeLandscapes.Biome,LandscapeAreaTypes.AreaType,LandscapeStatistics,LandscapeLocalities.Locality.LocalityType");

            return result.Select(_mapper.Map<LandscapeViewModel>);
        }

        public async new Task<int?> CreateAsync(CreateLandscapeViewModel viewModel)
        {
            await base.CreateAsync(viewModel);

            var repository = _unitOfWork.GetBaseRepository<Landscape>();
            var result = (await repository.Get(orderBy: l => l.OrderByDescending(e => e.Id))).FirstOrDefault();

            return result?.Id;
        }
    }
}
