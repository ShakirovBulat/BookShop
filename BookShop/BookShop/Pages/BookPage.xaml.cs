using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookShop.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookPage : ContentPage
    {

        public BookPage()
        {
            InitializeComponent();
        }
        
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void BackBtn_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}