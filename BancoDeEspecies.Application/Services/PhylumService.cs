using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Phylum;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IPhylumService : IBaseService<Phylum, PhylumViewModel, CreatePhylumViewModel>
    {
    }

    public class PhylumService : BaseService<Phylum, PhylumViewModel, CreatePhylumViewModel>, IPhylumService
    {
        public PhylumService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
