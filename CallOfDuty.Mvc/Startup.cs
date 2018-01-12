using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CallOfDuty.Mvc.Startup))]
namespace CallOfDuty.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
