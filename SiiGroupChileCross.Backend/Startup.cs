using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiiGroupChileCross.Backend.Startup))]
namespace SiiGroupChileCross.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
