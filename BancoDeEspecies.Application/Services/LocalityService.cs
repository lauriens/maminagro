using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Locality;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ILocalityService : IBaseService<Locality, LocalityViewModel, CreateLocalityViewModel>
    {
        new Task<int?> CreateAsync(CreateLocalityViewModel viewModel);
    }

    public class LocalityService : BaseService<Locality, LocalityViewModel, CreateLocalityViewModel>, ILocalityService
    {
        public LocalityService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task<IEnumerable<LocalityViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<Locality>();
            var result = await repository.Get(includeProperties: "LocalityType");

            return result.Select(_mapper.Map<LocalityViewModel>);
        }

        public async new Task<int?> CreateAsync(CreateLocalityViewModel viewModel)
        {
            await base.CreateAsync(viewModel);

            var repository = _unitOfWork.GetBaseRepository<Locality>();
            var result = (await repository.Get(orderBy: l => l.OrderByDescending(e => e.Id))).FirstOrDefault();

            return result?.Id;
        }
    }
}
