using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookShop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void Back_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AuthorizationPage());
        }

        private async void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Page1()));
        }
    }
}