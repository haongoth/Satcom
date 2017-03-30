using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SatComUsingMVC.Startup))]
namespace SatComUsingMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
