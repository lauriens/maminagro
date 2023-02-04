using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ISpeciesService : IBaseService<Specie, SpeciesViewModel>
    {
    }

    public class SpeciesService : BaseService<Specie, SpeciesViewModel>, ISpeciesService
    {
        public SpeciesService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
