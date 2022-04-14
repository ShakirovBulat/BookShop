using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookShop.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReviewsFormPage : ContentPage
    {
        public ReviewsFormPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void Clear()
        {
            star1.TextColor = Color.Gray;
            star2.TextColor = Color.Gray;
            star3.TextColor = Color.Gray;
            star4.TextColor = Color.Gray;
            star5.TextColor = Color.Gray;

        }

        private void star1_Tapped(object sender, EventArgs e)
        {
            Clear();
            star1.TextColor = Color.Yellow;

        }

        private void star2_Tapped(object sender, EventArgs e)
        {
            Clear();
            star1.TextColor = Color.Yellow;
            star2.TextColor = Color.Yellow;

        }

        private void star3_Tapped(object sender, EventArgs e)
        {
            Clear();
            star1.TextColor = Color.Yellow;
            star2.TextColor = Color.Yellow;
            star3.TextColor = Color.Yellow;

        }

        private void star4_Tapped(object sender, EventArgs e)
        {
            Clear();
            star1.TextColor = Color.Yellow;
            star2.TextColor = Color.Yellow;
            star3.TextColor = Color.Yellow;
            star4.TextColor = Color.Yellow;

        }

        private void star5_Tapped(object sender, EventArgs e)
        {
            Clear();
            star1.TextColor = Color.Yellow;
            star2.TextColor = Color.Yellow;
            star3.TextColor = Color.Yellow;
            star4.TextColor = Color.Yellow;
            star5.TextColor = Color.Yellow;
        }

        private async void SendBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}