namespace BancoDeEspecies.Application.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(int id, string entity) : base($"{entity} {id} not found.") { }
    }
}
