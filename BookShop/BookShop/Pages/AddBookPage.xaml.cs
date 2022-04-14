using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookShop.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddBookPage : ContentPage
    {

        public AddBookPage()
        {
            InitializeComponent();
        }
        private async void Back_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            await Navigation.PopAsync();
        }

        private async void BackLbl_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}