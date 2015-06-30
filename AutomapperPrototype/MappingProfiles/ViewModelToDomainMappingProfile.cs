using AutomapperPrototype.Domain;
using AutomapperPrototype.ViewModel;
using AutoMapper;

namespace AutomapperPrototype.MappingProfiles
{
    public class ViewModelToDomainMappingProfile :Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<PersonViewModel, Person>();
            Mapper.CreateMap<PersonListViewModel, Person>();
        }
    }
}