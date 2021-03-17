using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScheduleAdminTool.UI.MVC.Startup))]
namespace ScheduleAdminTool.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
