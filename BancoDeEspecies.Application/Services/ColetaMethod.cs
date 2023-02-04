using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IColetaMethodService : IBaseService<OccurrenceColetaMethod, ColetaMethodViewModel>
    {
    }

    public class ColetaMethodService : BaseService<OccurrenceColetaMethod, ColetaMethodViewModel>, IColetaMethodService
    {
        public ColetaMethodService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
