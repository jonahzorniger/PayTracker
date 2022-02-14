using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PayTracker.WebMVC.Startup))]
namespace PayTracker.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
