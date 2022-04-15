using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookShop
{
	public class TodoItemManager
	{
		IRestService restService;

		public TodoItemManager (IRestService service)
		{
			restService = service;
		}

		public Task<List<Users>> GetTasksAsync ()
		{
			return restService.RefreshDataAsync ();	
		}

		public Task SaveTaskAsync (Users item, bool isNewItem = false)
		{
			return restService.SaveTodoItemAsync (item, isNewItem);
		}

		public Task DeleteTaskAsync (Users item)
		{
			return restService.DeleteTodoItemAsync (item.ID);
		}
	}
}
