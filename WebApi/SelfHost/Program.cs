using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.SelfHost;
using System.Web.Http;
namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly.Load("WebApi,Version=1.0.0.0,Culture=neutral");
            Assembly.LoadFile(@"F:\git\TestWebApi\WebApi\WebApi\WebApi\bin\WebApi.dll");
            HttpSelfHostConfiguration configuration = new HttpSelfHostConfiguration("http://localhost/slfhost");
            using (HttpSelfHostServer httpServer = new HttpSelfHostServer(configuration))
            {
                httpServer.Configuration.Routes.MapHttpRoute(name: "DefaultApi", routeTemplate: "api/{controller}/{id}", defaults: new { id = RouteParameter.Optional });

                httpServer.OpenAsync();

                Console.Read();
            }
        }
    }
}
