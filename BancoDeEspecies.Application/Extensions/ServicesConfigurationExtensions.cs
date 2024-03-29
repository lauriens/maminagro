﻿using BancoDeEspecies.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BancoDeEspecies.Application.Extensions
{
    public static class ServicesConfigurationExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ServicesConfigurationExtensions));

            services.AddScoped<IAbundanceService, AbundanceService>();
            services.AddScoped<IAgroecosystemService, AgroecosystemService>();
            services.AddScoped<IAnthromeService, AnthromeService>();
            services.AddScoped<IAreaTypeService, AreaTypeService>();
            services.AddScoped<IBiomeService, BiomeService>();
            services.AddScoped<IBiomeLandscapeService, BiomeLandscapeService>();
            services.AddScoped<IClassService, ClassService>();
            services.AddScoped<IColetaMethodService, ColetaMethodService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ICultureService, CultureService>();
            services.AddScoped<ICultureSpecieService, CultureSpecieService>();
            services.AddScoped<IDomainService, DomainService>();
            services.AddScoped<IFamilyService, FamilyService>();
            services.AddScoped<IGenusService, GenusService>();
            services.AddScoped<IKingdomService, KingdomService>();
            services.AddScoped<ILandscapeAreaTypeService, LandscapeAreaTypeService>();
            services.AddScoped<ILandscapeService, LandscapeService>();
            services.AddScoped<ILandscapeLocalityService, LandscapeLocalityService>();
            services.AddScoped<ILandscapeMunicipalityService, LandscapeMunicipalityService>();
            services.AddScoped<ILandscapeStatisticService, LandscapeStatisticService>();
            services.AddScoped<ILocalityService, LocalityService>();
            services.AddScoped<IMaterialDestinationService, MaterialDestinationService>();
            services.AddScoped<IMunicipalityService, MunicipalityService>();
            services.AddScoped<IOccurrenceCultureService, OccurrenceCultureService>();
            services.AddScoped<IOccurrenceService, OccurrenceService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IPhylumService, PhylumService>();
            services.AddScoped<IReferenceService, ReferenceService>();
            services.AddScoped<IReferenceTypeService, ReferenceTypeService>();
            services.AddScoped<ISampleAreaTypeService, SampleAreaTypeService>();
            services.AddScoped<ISpeciesService, SpeciesService>();
            services.AddScoped<IStudyCollectMethodService, StudyCollectMethodService>();
            services.AddScoped<IThreatDegreeService, ThreatDegreeService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUfService, UfService>();

            return services;
        }
    }
}
