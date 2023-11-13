using System.ComponentModel.DataAnnotations.Schema;

namespace BancoDeEspecies.Domain.Models
{
    public class Biome
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private ICollection<BiomeLandscape> BiomeLandscapes { get; set; }

        [NotMapped]
        public IEnumerable<Landscape> Landscapes => BiomeLandscapes.Select(bl => bl.Landscape);
    }
}
