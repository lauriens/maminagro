using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IAnthromeService : IBaseService<Anthrome, AnthromeViewModel>
    {
    }

    public class AnthromeService : BaseService<Anthrome, AnthromeViewModel>, IAnthromeService
    {
        public AnthromeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
