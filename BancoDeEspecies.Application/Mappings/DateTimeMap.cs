using AutoMapper;

namespace BancoDeEspecies.Application.Mappings
{
    public class DateTimeMap : Profile
    {
        public DateTimeMap()
        {
            CreateMap<DateTime?, DateTime?>().ConvertUsing(new DateTimeTypeConverter());
        }
    }

    public class DateTimeTypeConverter : ITypeConverter<DateTime?, DateTime?>
    {
        DateTime? ITypeConverter<DateTime?, DateTime?>.Convert(DateTime? source, DateTime? destination, ResolutionContext context)
        {
            if (source == null) return null;
            return DateTime.SpecifyKind(source.Value, DateTimeKind.Unspecified);
        }
    }
}