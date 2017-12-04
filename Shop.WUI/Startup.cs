using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shop.WUI.Startup))]
namespace Shop.WUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
