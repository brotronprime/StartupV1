using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StartupBuilderSite.Startup))]
namespace StartupBuilderSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
