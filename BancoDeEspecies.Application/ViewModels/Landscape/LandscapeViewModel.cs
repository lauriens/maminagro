﻿using BancoDeEspecies.Application.ViewModels.Abundance;
using BancoDeEspecies.Application.ViewModels.Agroecosystem;
using BancoDeEspecies.Application.ViewModels.Anthrome;
using BancoDeEspecies.Application.ViewModels.AreaType;
using BancoDeEspecies.Application.ViewModels.Biome;
using BancoDeEspecies.Application.ViewModels.LandscapeStatistic;
using BancoDeEspecies.Application.ViewModels.Locality;
using BancoDeEspecies.Application.ViewModels.Municipality;
using BancoDeEspecies.Application.ViewModels.Reference;
using BancoDeEspecies.Application.ViewModels.SampleAreaType;

namespace BancoDeEspecies.Application.ViewModels.Landscape
{
    public class LandscapeViewModel
    {
        public int Id { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Radius { get; set; }
        public string? Description { get; set; }
        public bool? IsProtectedArea { get; set; }
        public AgroecosystemViewModel? Agroecosystem { get; set; }

        public AnthromeViewModel? Anthrome { get; set; }
        public IEnumerable<MunicipalityViewModel>? Municipalities { get; set; }
        public SampleAreaTypeViewModel? SampleAreaType { get; set; }
        public ReferenceViewModel? Reference { get; set; }
        public ICollection<AbundanceViewModel> Abundances { get; set; }
        public ICollection<BiomeViewModel> Biomes { get; set; }
        public ICollection<AreaTypeViewModel> AreaTypes { get; set; }
        public ICollection<LandscapeStatisticViewModel> LandscapeStatistics { get; set; }

        public ICollection<LocalityViewModel> Localities { get; set; }
    }
}
