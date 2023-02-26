using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Genus;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IGenusService : IBaseService<Genus, GenusViewModel, CreateGenusViewModel>
    {
    }

    public class GenusService : BaseService<Genus, GenusViewModel, CreateGenusViewModel>, IGenusService
    {
        public GenusService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
