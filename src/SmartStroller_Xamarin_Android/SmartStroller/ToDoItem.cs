using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace SmartStroller
{
	public class ToDoItem
	{
		public string Id { get; set; }

		[JsonProperty(PropertyName = "text")]
		public string Text { get; set; }

    [JsonProperty(PropertyName = "itemtype")]
    public string ItemType { get; set; }

		[JsonProperty(PropertyName = "complete")]
		public bool Complete { get; set; }

    [CreatedAt]
    public DateTime Created { get; set; }
	}

	public class ToDoItemWrapper : Java.Lang.Object
	{
		public ToDoItemWrapper (ToDoItem item)
		{
			ToDoItem = item;
		}

		public ToDoItem ToDoItem { get; private set; }
	}
}

