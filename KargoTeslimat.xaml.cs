using CepteSokApp.Models;
using CepteSokApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CepteSokApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KargoTeslimat : ContentPage
    {
        public KargoTeslimat()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#ffe000");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.Black;

            BindingContext = new MyListPageViewModel();
        }
        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as MyListModel;
            await Navigation.PushAsync(new Sepet(mydetails.Name, mydetails.ImageUrl, mydetails.ProductPrice, mydetails.ProductExplain));

        }

    }
}
