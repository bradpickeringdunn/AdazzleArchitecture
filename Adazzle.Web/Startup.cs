using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Adazzle.Web.Startup))]
namespace Adazzle.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
