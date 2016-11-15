using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebHostTest.Startup))]
namespace WebHostTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
