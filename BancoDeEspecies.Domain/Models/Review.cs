namespace BancoDeEspecies.Domain.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Observation { get; set; }
        public User User { get; set; }
    }
}
