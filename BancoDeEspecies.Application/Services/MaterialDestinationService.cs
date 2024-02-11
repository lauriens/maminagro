using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.MaterialDestination;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IMaterialDestinationService : IBaseService<MaterialDestination, MaterialDestinationViewModel, CreateMaterialDestinationViewModel>
    {
        Task<IEnumerable<MaterialDestinationListViewModel>> GetMaterialDestinationListAsync();
    }

    public class MaterialDestinationService : BaseService<MaterialDestination, MaterialDestinationViewModel, CreateMaterialDestinationViewModel>, IMaterialDestinationService
    {
        public MaterialDestinationService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public async Task<IEnumerable<MaterialDestinationListViewModel>> GetMaterialDestinationListAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<MaterialDestination>();

            var result = await repository.Get();

            return result.Select(_mapper.Map<MaterialDestinationListViewModel>);
        }
    }
}
