using Xamarin.Essentials;
using Xamarin.Forms;

namespace BookShop
{
    public static class Constants
    {
        public static string RestUrl = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000/api/todoitems/{0}" : "http://localhost:5000/api/todoitems/{0}";
    }
}
