using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ABIWebsite.Startup))]
namespace ABIWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
