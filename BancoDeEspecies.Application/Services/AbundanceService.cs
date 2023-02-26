using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Abundance;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IAbundanceService : IBaseService<Abundance, AbundanceViewModel, CreateAbundanceViewModel>
    {
    }

    public class AbundanceService : BaseService<Abundance, AbundanceViewModel, CreateAbundanceViewModel>, IAbundanceService
    {
        public AbundanceService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
