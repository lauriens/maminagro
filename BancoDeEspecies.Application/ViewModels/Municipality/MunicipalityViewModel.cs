using BancoDeEspecies.Application.ViewModels.Uf;

namespace BancoDeEspecies.Application.ViewModels.Municipality
{
    public class MunicipalityViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UfViewModel? Uf { get; set; }
    }
}
