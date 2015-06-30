using System;
using AutomapperPrototype.Domain;
using AutomapperPrototype.ViewModel;
using AutoMapper;

namespace AutomapperPrototype.MappingProfiles
{
    public class DomainToViewModelMappingProfile:Profile
    {
        protected override void Configure()
        {
            base.Configure();
            CreateMap<Person, PersonViewModel>().ReverseMap();
            CreateMap<Person, PersonListViewModel>()
                .ForMember(target => target.FullName,
                    map => map.MapFrom(src => string.Format("{0} {1}", src.FirstName, src.LastName)));

        }
    }
}