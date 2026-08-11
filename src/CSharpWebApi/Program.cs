using System.Web.Http;
using CSharpWebApi.Extensions;
using Microsoft.Owin.Hosting;
using Owin;

[assembly: Microsoft.Owin.OwinStartup(typeof(CSharpWebApi.Startup))]

namespace CSharpWebApi
{
    public static class Program
    {
        public static void Main()
        {
            OpenTelemetryBootstrap.Initialize();
            using (WebApp.Start<Startup>("http://localhost:5080/"))
            {
                System.Console.WriteLine("CSharp Web API running on http://localhost:5080/ (net472)");
                System.Console.WriteLine("Press Enter to exit.");
                System.Console.ReadLine();
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
            app.UseWebApi(config);
        }
    }
}
