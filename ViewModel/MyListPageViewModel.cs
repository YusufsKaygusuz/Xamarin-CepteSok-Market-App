using CepteSokApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CepteSokApp.ViewModel
{
    public class MyListPageViewModel
    {
        public ObservableCollection<MyListModel> ProductList { get; set; }

        public MyListPageViewModel()
        {
            ProductList = new ObservableCollection<MyListModel>();
            ProductList.Add(new MyListModel { Name = "Product1", ImageUrl = "kTeslimat1.jpg", ProductExplain = "Funko Pop Harley Quinn Holiday", ProductPrice= 189.90 });
            ProductList.Add(new MyListModel { Name = "Product2", ImageUrl = "kTeslimat2.jpg", ProductExplain = "Funko Pop Figür Captain America", ProductPrice = 349.90 });
            ProductList.Add(new MyListModel { Name = "Product3", ImageUrl = "kTeslimat3.jpg", ProductExplain = "Funko Pop Figür Zorii Bliss", ProductPrice = 329.90 });
            ProductList.Add(new MyListModel { Name = "Product4", ImageUrl = "kTeslimat4.jpg", ProductExplain = "Funko Pop Figür Jannah", ProductPrice = 99.90 });
            ProductList.Add(new MyListModel { Name = "Product5", ImageUrl = "kTeslimat5.jpg", ProductExplain = "Funko Pop Figür Poe Dameron", ProductPrice = 339.90 });

        }

    }
}
