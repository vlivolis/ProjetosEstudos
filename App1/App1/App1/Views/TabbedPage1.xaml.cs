using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1 ()
        {
            InitializeComponent();
        }
        

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var navigationPage = new MainPage();
            await Navigation.PushAsync(navigationPage,true);
        }
    }
}