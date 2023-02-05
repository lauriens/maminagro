namespace BancoDeEspecies.Application.ViewModels
{
    public class ReviewViewModel
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public string Observation { get; set; }
        public UserViewModel User { get; set; }
    }
}
