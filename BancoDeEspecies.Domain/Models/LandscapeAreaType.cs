namespace BancoDeEspecies.Domain.Models
{
    public class LandscapeAreaType
    {
        public int Id { get; set; }
        public int LandscapeId { get; set; }
        public int AreaTypeId { get; set; }
        public decimal? Percentage { get; set; }

        public AreaType AreaType { get; set; }
        public Landscape Landscape { get; set; }
    }
}
