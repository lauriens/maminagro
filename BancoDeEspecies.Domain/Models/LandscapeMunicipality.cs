namespace BancoDeEspecies.Domain.Models
{
    public class LandscapeMunicipality
    {
        public int LandscapeId { get; set; }
        public int MunicipalityId { get; set; }

        public Landscape Landscape { get; set; }
        public Municipality Municipality { get; set; }
    }
}
