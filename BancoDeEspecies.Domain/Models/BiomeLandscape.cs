namespace BancoDeEspecies.Domain.Models
{
    public class BiomeLandscape
    {
        public int BiomeId { get; set; }
        public int LandscapeId { get; set; }

        public Biome Biome { get; set; }
        public Landscape Landscape { get; set; }
    }
}
