using System.Collections.Generic;
using System.Linq;
using TestBusinessLogic.Models;
using TestService.DataAccess.Interfaces;

namespace TestService.DataAccess.Repositories
{
    /// <summary>
    /// Holds access to all of the test models.
    /// </summary>
    public class TestRepository : ITestRepository
    {
        private List<TestModel> _testModels = new List<TestModel>();

        /// <summary>
        /// Public constructor, injects the data.
        /// </summary>
        /// <param name="testModels"></param>
        public TestRepository(List<TestModel> testModels) => _testModels = testModels;

        /// <summary>
        /// Retreives the first model matching the given ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TestModel GetTestModel(int id) => _testModels.Find(m => m.ID == id);

        /// <summary>
        /// Returns the entire test model repository
        /// </summary>
        /// <returns></returns>
        public List<TestModel> GetTestModels() => _testModels;

        /// <summary>
        /// Adds the given model to the repository
        /// </summary>
        /// <param name="model"></param>
        public void InsertModel(TestModel model) => _testModels.Add(model);

        /// <summary>
        /// Updates a specific model in the repository
        /// </summary>
        /// <param name="model"></param>
        public void UpdateModel(TestModel model) => _testModels
            .Find(m => m.ID == model.ID)
            .Update(model);

        /// <summary>
        /// Inserts the given model if not present. Updates it if it is present.
        /// </summary>
        /// <param name="model"></param>
        public void UpsertModel(TestModel model)
        {
            if (null == _testModels.First(m => m.ID == model.ID))
                InsertModel(model);
            else
                UpdateModel(model);
        }

        /// <summary>
        /// Remove the given model from the repository by id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteModel(int id) => _testModels.Remove(_testModels.Find(m => m.ID == id));
    }
}