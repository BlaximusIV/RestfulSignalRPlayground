using Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TestBusinessLogic.Models;

namespace TestBusinessLogic.APIConsumption.TestServiceREST
{
    /// <summary>
    /// Class for consuming the test service api. Uses the singleton pattern for simplicity.
    /// </summary>
    public class RESTClient
    {
        #region Properties
        public static RESTClient Instance
        {
            get
            {
                if (null == _instance)
                    Configure();

                return _instance;
            }
        }
        #endregion

        #region Fields
        private static RESTClient _instance;
        private HttpClient _client;
        // Change beforehand
        private const string serviceURI = "http://localhost:2681";
        private const string testAPI = "api/Test";
        #endregion

        #region Public Methods
        /// <summary>
        /// Returns all of the Testmodels stored on the service.
        /// </summary>
        /// <returns></returns>
        public async Task<List<TestModel>> GetTestModelsAsync()
        {
            List<TestModel> returnModels = new List<TestModel>();

            try
            {
                // Get the data
                HttpResponseMessage response = await _client.GetAsync(testAPI);

                // Deserialize the data if it was successful
                if (response.IsSuccessStatusCode)
                {
                    byte[] data = await response.Content.ReadAsByteArrayAsync();

                    returnModels = ProtoSerializer
                        .DeserializeCollection<TestModel>(data)
                        .ToList();
                }
                else
                    // Report if the service call was not successful
                    throwCommunicationException(response.StatusCode);
            }
            catch (Exception ex)
            {
                logError(ex, "retrieve the test models");
            }

            return returnModels;
        }

        /// <summary>
        /// Sends the given model to the service to be inserted in the database.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task InsertModelAsync(TestModel model)
        {
            try
            {
                // Send request to server to insert the given model
                HttpResponseMessage response = await _client.PostAsync(testAPI, createContent(model));

                if (!response.IsSuccessStatusCode)
                    throwCommunicationException(response.StatusCode);
            }
            catch (Exception ex)
            {
                logError(ex, "inserting the test model");
            }
        }
        #endregion

        #region Private Methods
        private static void Configure()
        {
            // Instantiate the instance
            _instance = new RESTClient();

            // Instantiate and configure the HttpClient
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(serviceURI);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/x-protobuf"));

            _instance._client = client;
        }

        private void throwCommunicationException(HttpStatusCode code) =>
            throw new Exception($"An error occurred in communicating with the server. Error code:  {(int)code} ({code.ToString()})");

        private void logError(Exception ex, string intent) =>
            Console.WriteLine($"An error occurred attempting to {intent}.{Environment.NewLine}{ex.Message}");

        /// <summary>
        /// A helper method that creates content for the HTTPClient
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private ByteArrayContent createContent(TestModel model)
        {
            byte[] serializedModel = ProtoSerializer.Serialize(model);

            ByteArrayContent content = new ByteArrayContent(serializedModel);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/x-protobuf");

            return content;
        }

        #endregion
    }
}
