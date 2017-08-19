using System;
using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(SignalRchat.Startup))]
namespace SignalRchat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }

    }
}