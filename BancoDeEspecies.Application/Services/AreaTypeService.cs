using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IAreaTypeService : IBaseService<AreaType, AreaTypeViewModel>
    {
    }

    public class AreaTypeService : BaseService<AreaType, AreaTypeViewModel>, IAreaTypeService
    {
        public AreaTypeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
