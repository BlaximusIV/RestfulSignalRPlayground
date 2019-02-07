using System.Collections.Generic;
using TestService.DataAccess;
using TestService.DataAccess.Interfaces;
using TestService.DataAccess.Repositories;

namespace TestService
{
    /// <summary>
    /// Single source of truth for various application services
    /// </summary>
    public static class ServiceLocator
    {
        /// <summary>
        /// The ready accessor of all repositories.
        /// </summary>
        public static Dictionary<string, ITestRepository> Repositories = new Dictionary<string, ITestRepository>()
        {
            {"Test", new TestRepository(TestFactory.GenerateTestmodels()) }
        };
    }
}