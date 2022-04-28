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
    public partial class UrunAraPAge : ContentPage
    {
        
        public IList<Product> IList { get; set; }
        public UrunAraPAge()
        {
            InitializeComponent();

            IList = new List<Product>();
            IList.Add(new Product { Id = 1, Name = "elma", Description = "Elma Fuji Kg", ImageUrl="meyve2", Price = 9.95 });
            IList.Add(new Product { Id = 2, Name = "ananas", Description = "Ananas Adet", ImageUrl = "meyve3", Price = 29.95 });
            IList.Add(new Product { Id = 3, Name = "muzY", Description = "Muz Yerli Kg", ImageUrl = "meyve4", Price = 16.95 });
            IList.Add(new Product { Id = 4,  Name = "armut", Description = "Armut Sanmaria Kg", ImageUrl = "meyve1", Price = 19.95});
            IList.Add(new Product { Id = 5,  Name = "muzI", Description = "Muz Ithal Kg.", ImageUrl = "meyve5", Price = 22.90 });
            IList.Add(new Product { Id = 6, Name = "domates", Description = "Domates Salkım Kg.", ImageUrl = "sebze5", Price = 22.90 });
            IList.Add(new Product { Id = 7,  Name = "biberS", Description = "Biber Sivri Kg.", ImageUrl = "sebze6",  Price = 29.95 });
            IList.Add(new Product { Id = 8,  Name = "biberK", Description = "Biber Kıl Kg", ImageUrl = "sebze7", Price = 34.90 });

            IList.Add(new Product { Id = 9, Name = "sogan", Description = "Soğan Kuru Kg", ImageUrl = "sebze2", Price = 5.45 });
            IList.Add(new Product { Id = 10, Name = "patates", Description = "Patates Kg", ImageUrl = "sebze3", Price = 7.45 });
            IList.Add(new Product { Id = 11, Name = "sarımsak", Description = "Sarımsak Kuru Kg", ImageUrl = "sebze4", Price = 29.90 });
            IList.Add(new Product { Id = 12, Name = "sut1", Description = "İçim Süt 1 Lt", ImageUrl = "SutUrunler1", Price = 11.00 });
            IList.Add(new Product { Id = 13, Name = "sut2", Description = "Mis Bakraçlık Tam Yağlı Pastörize Süt 1 Lt", ImageUrl = "SutUrunler2", Price = 8.75 });

            IList.Add(new Product { Id = 14, Name = "peynir1", Description = "Mis Tam Yağlı Beyaz Peynir 1000 Gr", ImageUrl = "SutUrunler3", Price = 34.90 });
            IList.Add(new Product { Id = 15, Name = "peynir2", Description = "Pınar Az Yağlı Süzme Peynir 500 Gr", ImageUrl = "SutUrunler4", Price = 25.20 });
            IList.Add(new Product { Id = 16, Name = "yogurt", Description = "Mis Homojen Yoğurt 3 Kg", ImageUrl = "SutUrunler5", Price = 27.45 });
            IList.Add(new Product { Id = 17, Name = "kiyma", Description = "Lezzetlim Dana Kıyma 400 Gr", ImageUrl = "danaKiyma", Price = 41.50 });

            BindingContext = this;


        }
        private void searchTextChanged(object sender, EventArgs e)
        {
            var searchResult = IList.Where(c => c.Name.Contains(Search1.Text));
            Coll1.ItemsSource = searchResult;
        }
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public double Price { get; set; }
}