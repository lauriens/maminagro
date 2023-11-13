using System.ComponentModel.DataAnnotations.Schema;

namespace BancoDeEspecies.Domain.Models
{
    public class Municipality
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? UfId { get; set; }

        public Uf? Uf { get; set; }

        private ICollection<LandscapeMunicipality> LandscapeMunicipalities { get; set; }

        [NotMapped]
        public IEnumerable<Landscape> Landscapes => LandscapeMunicipalities.Select(lm => lm.Landscape);
    }
}
