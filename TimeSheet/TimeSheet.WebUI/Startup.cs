using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeSheet.WebUI.Startup))]
namespace TimeSheet.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
