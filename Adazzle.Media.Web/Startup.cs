using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Adazzle.Media.Web.Startup))]
namespace Adazzle.Media.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
