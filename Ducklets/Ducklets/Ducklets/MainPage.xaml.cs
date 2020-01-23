using ducklets;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ducklets
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ActuallyGetTheDuck();
        }
        private async void ActuallyGetTheDuck()
        {
            ActivityIndicator.IsVisible = true;
            var client = new HttpClient();
            client.BaseAddress = new Uri($"https://random-d.uk/api/random");
            var request = new HttpRequestMessage()
            {
                RequestUri = client.BaseAddress,
                Method = HttpMethod.Get,
            };
            var response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<Ducklet>(responseString);
                ImageBox.Source = model.Url;
                await Task.Delay(500);
                ActivityIndicator.IsVisible = false;
            }
        }

        private async void GetDuck(object sender, EventArgs e)
        {
            ActuallyGetTheDuck();
        }
    }
}
