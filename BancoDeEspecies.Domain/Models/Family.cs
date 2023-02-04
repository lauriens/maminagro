namespace BancoDeEspecies.Domain.Models
{
    public class Family
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Order Order { get; set; }
        public int? OrderId { get; set; }
        public ICollection<Genus> Genera { get; set; }
    }
}
