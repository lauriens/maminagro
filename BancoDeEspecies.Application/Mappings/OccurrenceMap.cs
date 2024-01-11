using AutoMapper;
using BancoDeEspecies.Application.ViewModels.Occurrence;
using BancoDeEspecies.Domain.Models;

namespace BancoDeEspecies.Application.Mappings
{
    public class OccurrenceMap : Profile
    {
        public OccurrenceMap()
        {
            CreateMap<DateTime?, DateTime?>().ConvertUsing(new DateTimeTypeConverter());
            CreateMap<Occurrence, OccurrenceViewModel>()
                .ForMember(o => o.OccurrenceType, opt => opt.MapFrom(src => src.OccurrenceType.ToString()));
            CreateMap<CreateOccurrenceViewModel, Occurrence>();
            CreateMap<EditOccurrenceViewModel, Occurrence>();
        }
    }

    public class DateTimeTypeConverter : ITypeConverter<DateTime?, DateTime?>
    {
        DateTime? ITypeConverter<DateTime?, DateTime?>.Convert(DateTime? source, DateTime? destination, ResolutionContext context)
        {
            if (source == null) return null;
            return DateTime.SpecifyKind(source.Value, DateTimeKind.Utc);
        }
    }
}
