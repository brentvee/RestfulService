using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using RestfulApi.Common.Contracts.Data;
using RestfulApi.Common.Contracts.Services;

namespace RestfulApi.Controllers
{
    public class ItemController : ApiController, IItemService
    {
		// example :/api/Item/1
	    [HttpGet]
		public Item GetItem(int id)
	    {
			var items = Items();

		    return items.FirstOrDefault(o => o.Id == id);
	    }

		// example :/api/Item?skip=1&take=2
	    [HttpGet]
	    public IEnumerable GetItems(int? skip = null, int? take = null)
	    {
		    return Items(skip,take);
	    }

	    private IEnumerable<Item> Items(int? skip=null,int?take=null)
	    {
		    var items = new List<Item>();
		    items.Add(new Item() {Id = 1, Name = "One"});
		    items.Add(new Item() {Id = 2, Name = "Two"});
		    items.Add(new Item() {Id = 3, Name = "Three"});
		    items.Add(new Item() {Id = 4, Name = "Four"});
		    var e = items.AsEnumerable();
		    
		    if (skip.HasValue)
		    {
			    e = e.Skip(skip.Value);
		    }
		    if (take.HasValue)
		    {
			    e = e.Take(take.Value);
		    }
		    return e;
	    }
    }
}
