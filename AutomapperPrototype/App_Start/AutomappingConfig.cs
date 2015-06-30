using System;
using AutomapperPrototype.MappingProfiles;
using AutoMapper;

namespace AutomapperPrototype
{
    public class AutomappingConfig
    {
        public static void Configure()
        {
            try
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.AddProfile<DomainToViewModelMappingProfile>();
                    cfg.AddProfile<ViewModelToDomainMappingProfile>();
                });

                Mapper.AssertConfigurationIsValid();
            }
            catch (Exception mappException)
            {
                throw new Exception(mappException.StackTrace);
            }
        } 
    }
}