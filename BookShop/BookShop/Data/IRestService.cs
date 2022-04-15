using BookShop.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookShop
{
	public interface IRestService
	{
		Task<List<Users>> RefreshDataAsync ();

		Task SaveTodoItemAsync (Users item, bool isNewItem);

		Task DeleteTodoItemAsync (string id);
	}
}
