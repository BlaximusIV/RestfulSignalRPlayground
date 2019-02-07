using System.Collections.Generic;
using System.Web.Http;
using TestBusinessLogic.Models;
using TestService.DataAccess.Interfaces;

namespace TestService.Controllers
{
    /// <summary>
    /// The controller for all things test
    /// </summary>
    public class TestController : ApiController
    {
        private static ITestRepository _repo = ServiceLocator.Repositories["Test"];

        /// <summary>
        /// Returns all of the repositories test models;
        /// </summary>
        /// <returns></returns>
        // GET api/<controller>
        public IEnumerable<TestModel> Get() => _repo.GetTestModels();

        /// <summary>
        /// Returns the model of the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TestModel</returns>
        // GET api/<controller>/5
        public TestModel Get(int id) => _repo.GetTestModel(id);

        /// <summary>
        /// Saves the given model in the repository
        /// </summary>
        /// <param name="model"></param>
        // POST api/<controller>
        public void Post([FromBody]TestModel model) => _repo.InsertModel(model);

        /// <summary>
        /// Upserts the given model to the repository
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        // PUT api/<controller>/5
        public void Put(int id, [FromBody]TestModel model) => _repo.UpsertModel(model);

        /// <summary>
        /// Deletes a model from the repository by the given id
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<controller>/5
        public void Delete(int id) => _repo.DeleteModel(id);
    }
}