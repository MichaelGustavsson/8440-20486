using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CourseTracker.Startup))]
namespace CourseTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
