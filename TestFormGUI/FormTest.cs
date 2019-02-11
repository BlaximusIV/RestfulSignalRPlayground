using Microsoft.AspNet.SignalR.Client;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestBusinessLogic.API_Consumption.TestServiceREST;
using TestBusinessLogic.Models;

namespace TestFormGUI
{
    public partial class FormTest : Form
    {
        // Set the hub values before continuing.
        // The hub could potentially be injected, but this is a small application, so I don't feel it necessary.
        private const string _hubURI = "";
        private const string _hubName = "Test";
        private static readonly HubConnection _connection = new HubConnection(_hubURI);
        private static readonly IHubProxy _hub = _connection.CreateHubProxy(_hubName);

        private BindingList<TestModel> gridData = new BindingList<TestModel>();



        public FormTest()
        {
            InitializeComponent();

            // Calling asynchronously as the hub in this application is only used for broadcasts between users
            // I'm typically going to be the only user. 
            InitializeHub();
            InitializeData();
        }

        private async Task InitializeHub()
        {
            // Subscribe to hub events

            // Start the Hub. Using a task to synchronously 
            await _connection.Start();
        }


        private async void InitializeData() => await getAllData();

        private async void btnGetAll_Click(object sender, EventArgs e) =>  await getAllData();

        private void btnGetID_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                clearInput();
            }
            catch
            {

            }

        }

        private void clearInput()
        {

        }

        private async Task getAllData() =>
            gridData = new BindingList<TestModel>(await RESTClient.Instance.GetTestModelsAsync());
    }
}
