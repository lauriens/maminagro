using BancoDeEspecies.Domain.Enums;

namespace BancoDeEspecies.Application.ViewModels.OccurrenceColetaMethod
{
    public class CreateOccurrenceColetaMethodViewModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public ColetaMethodType? Type { get; set; }
    }
}
