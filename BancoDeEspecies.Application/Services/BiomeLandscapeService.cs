using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.BiomeLandscape;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IBiomeLandscapeService : IBaseService<BiomeLandscape, CreateBiomeLandscapeViewModel, CreateBiomeLandscapeViewModel>
    {
    }

    public class BiomeLandscapeService : BaseService<BiomeLandscape, CreateBiomeLandscapeViewModel, CreateBiomeLandscapeViewModel>, IBiomeLandscapeService
    {
        public BiomeLandscapeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public new async Task<IEnumerable<CreateBiomeLandscapeViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public new async Task<CreateBiomeLandscapeViewModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
