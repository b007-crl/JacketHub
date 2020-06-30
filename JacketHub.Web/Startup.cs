using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JacketHub.Web.Startup))]
namespace JacketHub.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
