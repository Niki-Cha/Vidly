using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidLy.Startup))]
namespace VidLy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
