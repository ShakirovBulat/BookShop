using Xamarin.Forms;

[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "MaterialIconsFont")]
namespace BookShop
{
    public partial class App : Application
    {
        public static TodoItemManager TodoManager { get; private set; }
        public App()
        {
            InitializeComponent();

            TodoManager = new TodoItemManager(new RestService());
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
