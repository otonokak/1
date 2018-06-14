using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using GodelTech.AreaMonitor.Api;

[assembly: OwinStartup(typeof(Startup))]

namespace GodelTech.AreaMonitor.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            var container = AutofacConfig.ConfigureContainer().Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
            app.UseWebApi(config);
        }
    }
}