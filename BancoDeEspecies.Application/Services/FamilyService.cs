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
    }
}
