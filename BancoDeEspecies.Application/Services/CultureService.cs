using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Culture;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ICultureService : IBaseService<Culture, CultureViewModel, CreateCultureViewModel>
    {
    }

    public class CultureService : BaseService<Culture, CultureViewModel, CreateCultureViewModel>, ICultureService
    {
        public CultureService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
