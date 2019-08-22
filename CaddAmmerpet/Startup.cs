using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CaddAmmerpet.Startup))]
namespace CaddAmmerpet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
