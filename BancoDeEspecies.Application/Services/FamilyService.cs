using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IFamilyService : IBaseService<Family, FamilyViewModel>
    {
    }

    public class FamilyService : BaseService<Family, FamilyViewModel>, IFamilyService
    {
        public FamilyService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
