using System.Web.Http;
using System.Web.Http.Dependencies;
using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using GodelTech.AreaMonitor.Dal.Context;
using GodelTech.AreaMonitor.Dal.Interfaces;
using GodelTech.AreaMonitor.Dal.Repositories;

namespace GodelTech.AreaMonitor.Api
{
    public class AutofacConfig
    {
        private static void RegisterServices(ContainerBuilder builder)
        {
        }

        private static void RegisterRepository(ContainerBuilder builder)
        {
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerRequest();
            builder.RegisterType<UserWebPageRepository>().As<IUserWebPageRepository>().InstancePerRequest();
            builder.RegisterType<WebPageRepository>().As<IWebPageRepository>().InstancePerRequest();
            builder.RegisterType<WebPageUpdateRepository>().As<IWebPageUpdateRepository>().InstancePerRequest();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
        }

        private static void RegisterContext(ContainerBuilder builder)
        {
            builder.RegisterType<AreaMonitorContext>().AsSelf().InstancePerRequest();
        }

        private static void RegisterAutomapper(ContainerBuilder builder)
        {
            builder.RegisterType<AutomapperConfig>().AsSelf().SingleInstance();
            builder.Register(c => new MapperConfiguration(cfg => cfg.AddProfile(c.Resolve<AutomapperConfig>()))).AsSelf().SingleInstance();
            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();
        }

        private static ContainerBuilder ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            RegisterServices(builder);
            RegisterContext(builder);
            RegisterRepository(builder);
            RegisterAutomapper(builder);
            return builder;
        }

        public static IDependencyResolver CreateResolver()
        {
            var container = ConfigureContainer().Build();
            return new AutofacWebApiDependencyResolver(container);
        }
    }
}