namespace BancoDeEspecies.Domain.Models
{
    public class Agroecosystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public IEnumerable<Landscape> Landscapes { get; set; }
    }
}
