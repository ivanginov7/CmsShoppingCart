using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CmsShoppingCart.Startup))]
namespace CmsShoppingCart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}