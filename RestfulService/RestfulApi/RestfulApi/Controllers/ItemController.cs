using System;
using System.Collections;
using System.Linq;
using System.Web.Http;
using RestfulApi.Core.Contracts;
using RestfulApi.Model.Models;

namespace RestfulApi.Controllers
{
    public class ItemController : ApiController
    {
	    public IItemService ItemService { get; set; }
	    //public IUnityContainer Container { get; set; }

	    public ItemController(IItemService itemService)
	    {
		    ItemService = itemService;
	    }

		/*// example :/api/item/barcode=1
		[HttpGet]
		public DAT_LOSTEILE GetItem(string barcode)
		{
			return ItemService.GetItemByBarcode(barcode);
		}*/

		// example :/api/item?since=2014-01-01&skip=10&take=10
		[HttpGet]
		public IEnumerable GetItems(DateTime since,int? skip = null, int? take = null)
		{
			return ItemService.GetItemsSince(since, skip, take).ToList();
		}
    }
}
