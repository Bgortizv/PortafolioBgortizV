using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SitioWebBayronOrtiz.Startup))]
namespace SitioWebBayronOrtiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
