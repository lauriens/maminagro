using BancoDeEspecies.Application.ViewModels.Class;

namespace BancoDeEspecies.Application.ViewModels.Order
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ClassViewModel? Class { get; set; }
    }
}
