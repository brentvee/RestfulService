using System.Collections;
using System.Collections.Generic;
using System.Web.Http;
using MvcApp.Models;

namespace MvcApp.Controllers
{
	public class ItemController : ApiController
	{
		[HttpGet]
		public IEnumerable Get()
		{
			var items = new List<Item>()
			{
				new Item() {Name = "Rahul"},
				new Item() {Name = "Chinmoy"},
				new Item() {Name = "Charu"}
			};

			return items;
		}
	}
}
