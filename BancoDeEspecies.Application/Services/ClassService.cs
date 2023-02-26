using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Class;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IClassService : IBaseService<Class, ClassViewModel, CreateClassViewModel>
    {
    }

    public class ClassService : BaseService<Class, ClassViewModel, CreateClassViewModel>, IClassService
    {
        public ClassService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
