namespace BancoDeEspecies.Domain.Models
{
    public class LandscapeLocality
    {
        public int LandscapeId { get; set; }
        public int LocalityId { get; set; }
        public Landscape Landscape { get; set; }
        public Locality Locality { get; set; }
    }
}
