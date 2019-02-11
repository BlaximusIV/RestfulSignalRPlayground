using Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TestBusinessLogic.Models;

namespace TestBusinessLogic.API_Consumption.TestServiceREST
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
        public async Task<List<TestModel>> GetTestModelsAsync()
        {
            List<TestModel> returnModels = new List<TestModel>();

            try
            {
                HttpResponseMessage response = await _client.GetAsync(testAPI);
                if (response.IsSuccessStatusCode)
                {
                    byte[] data = await response.Content.ReadAsByteArrayAsync();
                    returnModels = Serializer.Serializer
                        .DeserializeProtoObjects<TestModel>(data)
                        .ToList();
                }
                else
                    throwCommunicationException(response.StatusCode);
            }
            catch(Exception ex)
            {
                logError(ex, "retrieve the test models.");
            }

            return returnModels;
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
            throw new Exception($"An error occurred in communicating with the server. Error code: {code.ToString()}");

        private void logError(Exception ex, string intent) =>
            Console.WriteLine($"An error occurred attempting to {intent}.{Environment.NewLine}{ex.Message}");
        #endregion
    }
}
