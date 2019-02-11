using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace TestService.SignalRHubs
{
    [HubName("Test")]
    public class Testhub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}