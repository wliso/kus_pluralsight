using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kus_pluralsight2.Startup))]
namespace kus_pluralsight2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
