using Autofac.Integration.WebApi;
using GodelTech.AreaMonitor.Api.App_Start;
using GodelTech.AreaMonitor.Api.Utils;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(Startup))]

namespace GodelTech.AreaMonitor.Api.App_Start
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