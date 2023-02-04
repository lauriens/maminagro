using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IPhylaService : IBaseService<Phylum, PhylumViewModel>
    {
    }

    public class PhylaService : BaseService<Phylum, PhylumViewModel>, IPhylaService
    {
        public PhylaService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
