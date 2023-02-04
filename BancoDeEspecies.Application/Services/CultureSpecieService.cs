using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ICultureSpecieService : IBaseService<CultureSpecie, CultureSpecieViewModel>
    {
    }

    public class CultureSpecieService : BaseService<CultureSpecie, CultureSpecieViewModel>, ICultureSpecieService
    {
        public CultureSpecieService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
