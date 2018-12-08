using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthorizeDemo.Startup))]
namespace AuthorizeDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
