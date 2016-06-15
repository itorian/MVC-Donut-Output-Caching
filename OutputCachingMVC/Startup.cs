using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OutputCachingMVC.Startup))]
namespace OutputCachingMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
