using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using AutomapperPrototype.Controllers;
using AutoMapper;

namespace AutomapperPrototype
{
    public class AutofacConfig
    {
        public static void Configure()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.Register(x => Mapper.Engine).As<IMappingEngine>().SingleInstance();
            containerBuilder.RegisterType<ValuesController>();
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(containerBuilder.Build());
        }
    }
}