using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CepteSokApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var images = new List<String>
            {
                "Kampanya1.png",
                "Kampanya2.png",
                "Kampanya3.png",
            };
            MainCarouselView.ItemsSource = images;
        }

        async void haftaFirsatClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new haftaFirsatlari());
        }

        async void kTeslimClicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new KargoTeslimat());
        }
    }
}
