using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bikely.Startup))]
namespace Bikely
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
