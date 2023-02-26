using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.AreaType;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IAreaTypeService : IBaseService<AreaType, AreaTypeViewModel, CreateAreaTypeViewModel>
    {
    }

    public class AreaTypeService : BaseService<AreaType, AreaTypeViewModel, CreateAreaTypeViewModel>, IAreaTypeService
    {
        public AreaTypeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
