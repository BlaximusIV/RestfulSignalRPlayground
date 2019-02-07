using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBusinessLogic.Models;

namespace TestService.DataAccess.Interfaces
{
    /// <summary>
    /// The interface for the application's test repository.
    /// </summary>
    public interface ITestRepository
    {
        /// <summary>
        /// Return the given model, by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TestModel GetTestModel(int id);
        /// <summary>
        /// Returns all models in the repository
        /// </summary>
        /// <returns></returns>
        List<TestModel> GetTestModels();
        /// <summary>
        /// Saves the given model into the repository.
        /// </summary>
        /// <param name="model"></param>
        void InsertModel(TestModel model);
        /// <summary>
        /// Updates the given model in the repository.
        /// </summary>
        /// <param name="model"></param>
        void UpdateModel(TestModel model);
        /// <summary>
        /// Inserts the given model in the repository if it is not present.
        /// Otherwise, the model in the repository is updated with the given model.
        /// </summary>
        /// <param name="model"></param>
        void UpsertModel(TestModel model);
        /// <summary>
        /// Removes a model from the repository by the given id
        /// </summary>
        /// <param name="id"></param>
        void DeleteModel(int id);
    }
}
