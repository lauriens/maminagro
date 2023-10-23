using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.User;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IUserService : IBaseService<User, UserViewModel, CreateUserViewModel>
    {
    }

    public class UserService : BaseService<User, UserViewModel, CreateUserViewModel>, IUserService
    {
        public UserService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task<IEnumerable<UserViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<User>();
            var result = await repository.Get(includeProperties: "Country");

            return result.Select(_mapper.Map<UserViewModel>);
        }
    }
}
