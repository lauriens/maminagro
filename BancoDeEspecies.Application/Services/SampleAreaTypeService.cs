using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ISampleAreaTypeService : IBaseService<SampleAreaType, SampleAreaTypeViewModel>
    {
    }

    public class SampleAreaTypeService : BaseService<SampleAreaType, SampleAreaTypeViewModel>, ISampleAreaTypeService
    {
        public SampleAreaTypeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
