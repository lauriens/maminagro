using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Biome;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface IBiomeService : IBaseService<Biome, BiomeViewModel, CreateBiomeViewModel>
    {
    }

    public class BiomeService : BaseService<Biome, BiomeViewModel, CreateBiomeViewModel>, IBiomeService
    {
        public BiomeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
    }
}
