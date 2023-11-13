using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Agroecosystem;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IAgroecosystemService : IBaseService<Agroecosystem, AgroecosystemViewModel, CreateAgroecosystemViewModel>
    {
    }

    internal class AgroecosystemService : BaseService<Agroecosystem, AgroecosystemViewModel, CreateAgroecosystemViewModel>, IAgroecosystemService
    {
        public AgroecosystemService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
    }
}
