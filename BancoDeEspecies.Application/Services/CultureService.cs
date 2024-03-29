﻿using AutoMapper;
using BancoDeEspecies.Application.Services.Base;
using BancoDeEspecies.Application.ViewModels.Culture;
using BancoDeEspecies.DataAccess.UnitOfWork;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Services
{
    public interface ICultureService : IBaseService<Culture, CultureViewModel, CreateCultureViewModel>
    {
        new Task<int?> CreateAsync(CreateCultureViewModel viewModel);
        Task<IEnumerable<CultureViewModel>> GetLandscapeCulturesAsync(int landscapeId);
    }

    public class CultureService : BaseService<Culture, CultureViewModel, CreateCultureViewModel>, ICultureService
    {
        public CultureService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        public new async Task<IEnumerable<CultureViewModel>> GetAllAsync()
        {
            var repository = _unitOfWork.GetBaseRepository<Culture>();
            var result = await repository.Get(includeProperties: "Specie.Genus.Family.Order.Class.Phylum.Kingdom.Domain,OccurrenceCultures.Occurrence.OccurrenceColetaMethod,OccurrenceCultures.Occurrence.Reference.ReferenceType,OccurrenceCultures.Occurrence.Reference.StudyCollectMethods.MaterialDestination,OccurrenceCultures.Occurrence.ThreatDegree,OccurrenceCultures.Occurrence.Abundances,OccurrenceCultures.Occurrence.Locality.LocalityType");

            return result.Select(_mapper.Map<CultureViewModel>);
        }

        public async new Task<int?> CreateAsync(CreateCultureViewModel viewModel)
        {
            await base.CreateAsync(viewModel);

            var repository = _unitOfWork.GetBaseRepository<Culture>();
            var result = (await repository.Get(orderBy: l => l.OrderByDescending(e => e.Id))).FirstOrDefault();

            return result?.Id;
        }

        public async Task<IEnumerable<CultureViewModel>> GetLandscapeCulturesAsync(int landscapeId)
        {
            var repository = _unitOfWork.GetBaseRepository<Culture>();
            var result = await repository.Get(c => c.LandscapeId == landscapeId, includeProperties: "Specie.Genus");

            return result.Select(_mapper.Map<CultureViewModel>);
        }
    }
}
