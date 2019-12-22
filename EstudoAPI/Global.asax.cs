using EstudoAPI.Services;
using EstudoAPI.Services.Interfaces;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace EstudoAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var container = new Container();
            container.Register<IClienteService, ClienteService>();

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}
