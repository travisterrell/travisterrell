using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravisTerrell.Web.Startup))]
namespace TravisTerrell.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
