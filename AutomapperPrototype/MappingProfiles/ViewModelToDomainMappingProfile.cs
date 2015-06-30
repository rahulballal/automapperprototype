using AutomapperPrototype.Domain;
using AutomapperPrototype.ViewModel;
using AutoMapper;

namespace AutomapperPrototype.MappingProfiles
{
    public class ViewModelToDomainMappingProfile :Profile
    {
        protected override void Configure()
        {
            // Not needed when you reversemap in one place.
            //Mapper.CreateMap<PersonViewModel, Person>();
            Mapper.CreateMap<PersonListViewModel, Person>()
                .ForMember( tgt => tgt.FirstName, map => map.MapFrom(src => src.FullName.Split(' ')[0]))
                .ForMember(tgt => tgt.LastName, map => map.MapFrom(src => src.FullName.Split(' ')[1]));
        }
    }
}