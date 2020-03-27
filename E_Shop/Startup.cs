using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Shop.Startup))]
namespace E_Shop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
