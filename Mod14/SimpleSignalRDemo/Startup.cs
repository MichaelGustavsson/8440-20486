using Microsoft.Owin;
using Owin;
using SimpleSignalRDemo;

[assembly: OwinStartup(typeof(Startup))]

namespace SimpleSignalRDemo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}