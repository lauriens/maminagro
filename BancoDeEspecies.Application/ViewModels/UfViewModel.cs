namespace BancoDeEspecies.Application.ViewModels
{
    public class UfViewModel
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Abbreviation { get; set; }
        public CountryViewModel Country { get; set; }
    }
}
