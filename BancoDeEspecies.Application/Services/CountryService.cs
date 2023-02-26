using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Country;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ICountryService : IBaseService<Country, CountryViewModel, CreateCountryViewModel>
    {
    }

    public class CountryService : BaseService<Country, CountryViewModel, CreateCountryViewModel>, ICountryService
    {
        public CountryService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
