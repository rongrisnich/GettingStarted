using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GettingStarted.Startup))]
namespace GettingStarted
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
