using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WSIZ.Startup))]
namespace WSIZ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
