using AutomapperPrototype.Domain;
using AutomapperPrototype.ViewModel;
using AutoMapper;

namespace AutomapperPrototype.MappingProfiles
{
    public class DomainToViewModelMappingProfile:Profile
    {
        public string Name { get; private set; } 

        public DomainToViewModelMappingProfile(string profileName)
        {
            Name = profileName;
        }

        public DomainToViewModelMappingProfile()
        {
            
        }

        protected override void Configure()
        {
            base.Configure();
            CreateMap<Person, PersonViewModel>();

        }
    }
}