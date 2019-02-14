using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace TestService.SignalRHubs
{
    /// <summary>
    /// A SignalR hub for broadcasting to all subscribed clients
    /// </summary>
    [HubName("Test")]
    public class TestHub : Hub
    {
        /// <summary>
        /// The hub context necessary to call clients from static methods.
        /// This enables calling the hub methods from 
        /// </summary>
        private static IHubContext _hubContext = GlobalHost.ConnectionManager.GetHubContext<TestHub>();

        /// <summary>
        /// Broadcasts to all connected clients to add the specified TestModel.
        /// </summary>
        /// <param name="model"></param>
        public static void AddTestModel(byte[] model) =>
            _hubContext.Clients.All.AddTestModel(model);

        /// <summary>
        /// Broadcasts to all connected clients that the specified TestModel should be removed.
        /// </summary>
        /// <param name="id"></param>
        public static void RemoveTestModel(int id) =>
            _hubContext.Clients.All.RemoveTestModel(id);
    }
}