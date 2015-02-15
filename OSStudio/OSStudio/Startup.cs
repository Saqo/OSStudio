using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OSStudio.Startup))]
namespace OSStudio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
