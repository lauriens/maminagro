using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Anthrome;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IAnthromeService : IBaseService<Anthrome, AnthromeViewModel, CreateAnthromeViewModel>
    {
    }

    public class AnthromeService : BaseService<Anthrome, AnthromeViewModel, CreateAnthromeViewModel>, IAnthromeService
    {
        public AnthromeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
