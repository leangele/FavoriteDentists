using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FavoriteDentists.Startup))]
namespace FavoriteDentists
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
