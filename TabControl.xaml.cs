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
    public partial class TabControl : TabbedPage
    {
        public TabControl()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}