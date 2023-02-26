using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.Application.ViewModels.OccurrenceColetaMethod;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IColetaMethodService : IBaseService<OccurrenceColetaMethod, OccurrenceColetaMethodViewModel, CreateOccurrenceColetaMethodViewModel>
    {
    }

    public class ColetaMethodService : BaseService<OccurrenceColetaMethod, OccurrenceColetaMethodViewModel, CreateOccurrenceColetaMethodViewModel>, IColetaMethodService
    {
        public ColetaMethodService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
