using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Municipality;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IMunicipalityService : IBaseService<Municipality, MunicipalityViewModel, CreateMunicipalityViewModel>
    {
    }

    public class MunicipalityService : BaseService<Municipality, MunicipalityViewModel, CreateMunicipalityViewModel>, IMunicipalityService
    {
        public MunicipalityService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public new async Task<IEnumerable<MunicipalityViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<Municipality>();
            var result = await repository.Get(includeProperties: "Uf.Country");

            return result.Select(_mapper.Map<MunicipalityViewModel>);
        }
    }
}
