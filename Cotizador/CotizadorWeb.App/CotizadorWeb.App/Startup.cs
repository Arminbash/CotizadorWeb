using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OWIN.Startup))]
namespace OWIN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
