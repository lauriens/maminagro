using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.CultureSpecie;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ICultureSpecieService : IBaseService<CultureSpecie, CultureSpecieViewModel, CreateCultureSpecieViewModel>
    {
    }

    public class CultureSpecieService : BaseService<CultureSpecie, CultureSpecieViewModel, CreateCultureSpecieViewModel>, ICultureSpecieService
    {
        public CultureSpecieService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
