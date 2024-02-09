using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Family;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IFamilyService : IBaseService<Family, FamilyViewModel, CreateFamilyViewModel>
    {
    }

    public class FamilyService : BaseService<Family, FamilyViewModel, CreateFamilyViewModel>, IFamilyService
    {
        public FamilyService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task<FamilyViewModel> GetByIdAsync(int id)
        {
            var repository = _unitOfWork.GetBaseRepository<Family>();
            var result = await repository.Get(f => f.Id == id, includeProperties: "Order.Class.Phylum.Kingdom.Domain");

            return _mapper.Map<FamilyViewModel>(result.FirstOrDefault());
        }
    }
}
