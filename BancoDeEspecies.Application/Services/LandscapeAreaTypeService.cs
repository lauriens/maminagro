﻿using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.LandscapeAreaType;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ILandscapeAreaTypeService : IBaseService<LandscapeAreaType, LandscapeAreaTypeViewModel, CreateLandscapeAreaTypeViewModel>
    {
    }

    public class LandscapeAreaTypeService : BaseService<LandscapeAreaType, LandscapeAreaTypeViewModel, CreateLandscapeAreaTypeViewModel>, ILandscapeAreaTypeService
    {
        public LandscapeAreaTypeService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task<IEnumerable<LandscapeAreaTypeViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<LandscapeAreaType>();
            var result = await repository.Get(includeProperties: "Landscape,AreaType");

            return result.Select(_mapper.Map<LandscapeAreaTypeViewModel>);
        }
    }
}
