namespace BancoDeEspecies.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? Name { get; set; } = null;
        public Class? Class { get; set; } = null;
        public int? ClassId { get; set; }
        public ICollection<Family> Families { get; set; }
    }
}
