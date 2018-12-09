using eHealthWorkshopGroup4.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace eHealthWorkshopGroup4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    class MainPage : TabbedPage
    {
        public MainPage()
        {
            this.Title = "MyMain";
            this.Children.Add(new Profile());
            this.Children.Add(new Home());
            this.Children.Add(new Messages());
            this.Children.Add(new Train());
            this.Children.Add(new Info());

        }
    }
}