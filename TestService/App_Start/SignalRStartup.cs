using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TestService.App_Start.SignalRStartup))]

namespace TestService.App_Start
{
    /// <summary>
    /// An Owin Startup class for configuring SignalR.
    /// </summary>
    public class SignalRStartup
    {
        /// <summary>
        /// Configures the app with signalr
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.MapSignalR();
        }
    }
}
