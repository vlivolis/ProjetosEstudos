using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.View
{
    public partial class MainPage : ContentPage
    {
        private const string url = "https://economia.awesomeapi.com.br/all";
        private HttpClient _Client = new HttpClient();
        public class Post
        {
            public int userId { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public string body { get; set; }
        }

        public MainPage()
        {
            InitializeComponent();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            HttpResponseMessage response = await _Client.GetAsync(url);
            var product = await response.Content.ReadAsStringAsync();
            
            Console.Write(response);
            labelTitle.Text = response.ToString();

            var navigationPage = new TabbedPage1();
            await Navigation.PushAsync(navigationPage,true);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            //var navigationPage = new Page1();
            //await Navigation.PushAsync(navigationPage, true);
        }
    }
}
