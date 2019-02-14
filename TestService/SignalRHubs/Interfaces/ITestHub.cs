using TestBusinessLogic.Models;

namespace TestService.SignalRHubs.Interfaces
{
    /// <summary>
    /// Interface to allow for strong typing on implementing SignalR hubs
    /// </summary>
    public interface ITestHub
    {
        /// <summary>
        /// Add the given test model to 
        /// </summary>
        /// <param name="model"></param>
        void AddTestModel(TestModel model);
        /// <summary>
        /// Remove a test model by the given ID
        /// </summary>
        /// <param name="id"></param>
        void RemoveTestModel(int id);
    }
}
