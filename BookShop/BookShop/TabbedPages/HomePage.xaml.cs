using System;
using BookShop.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookShop.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

        }
        

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddBookPage());
        }
    }
}