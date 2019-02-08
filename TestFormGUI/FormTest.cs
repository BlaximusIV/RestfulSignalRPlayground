using System;
using System.Net.Http;
using System.Windows.Forms;

namespace TestFormGUI
{
    public partial class FormTest : Form
    {
        private static readonly HttpClient _client = new HttpClient();

        public FormTest()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {

        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {

        }

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
    }
}
