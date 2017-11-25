using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CWProBusinessWeb.Startup))]
namespace CWProBusinessWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
