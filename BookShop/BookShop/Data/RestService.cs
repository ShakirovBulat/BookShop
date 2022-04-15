using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using BookShop.Models;

namespace BookShop
{
    public class RestService : IRestService
    {
        HttpClient client;
        JsonSerializerOptions serializerOptions;

        public List<Users> Items { get; private set; }

        public RestService()
        {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<List<Users>> RefreshDataAsync()
        {
            Items = new List<Users>();

            Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Items = JsonSerializer.Deserialize<List<Users>>(content, serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tошибка {0}", ex.Message);
            }

            return Items;
        }

        public async Task SaveTodoItemAsync(Users item, bool isNewItem = false)
        {
            Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            try
            {
                string json = JsonSerializer.Serialize<Users>(item, serializerOptions);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                if (isNewItem)
                {
                    response = await client.PostAsync(uri, content);
                }
                else
                {
                    response = await client.PutAsync(uri, content);
                }

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tTodoItem упсешно добавлено .");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tОШИБКА {0}", ex.Message);
            }
        }

        public async Task DeleteTodoItemAsync(string id)
        {
            Uri uri = new Uri(string.Format(Constants.RestUrl, id));

            try
            {
                HttpResponseMessage response = await client.DeleteAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tTodoItem удалено.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tошибка {0}", ex.Message);
            }
        }
    }
}
