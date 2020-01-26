using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExamples.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();

            var menuItems = new List<MenuPageItem> { new MenuPageItem() { Name = "About" } };

            ListViewMenu.ItemsSource = menuItems;

        }
    }

    public class MenuPageItem
    {
        public string Name { get; set; }
    }
}