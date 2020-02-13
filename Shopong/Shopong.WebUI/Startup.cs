using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shopong.WebUI.Startup))]
namespace Shopong.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
