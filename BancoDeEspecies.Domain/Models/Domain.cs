namespace BancoDeEspecies.Domain.Models
{
    public class Domain
    {
        public int Id { get; set; }
        public string? Name { get; set; } = null;
        public ICollection<Kingdom> Kingdoms { get; set; }
    }
}
