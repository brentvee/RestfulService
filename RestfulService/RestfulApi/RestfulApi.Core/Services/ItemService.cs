using System.Linq;
using Microsoft.Practices.Unity;
using RestfulApi.Core.Contracts;
using RestfulApi.Model.Models;

namespace RestfulApi.Core.Services
{
	public class ItemService : ServiceBase, IItemService
	{

		public IQueryable<DAT_LOSTEILE> GetItemsByBarcode(string barcode, int? skip, int? take)
		{
			var items = GetItemsWithSkipTake(skip, take);
			items = items.Where(o => o.BARCODE == barcode);
			return items;
		}

		public DAT_LOSTEILE GetItemByBarcode(string barcode)
		{
			return Context.DAT_LOSTEILE.OrderByDescending(o => o.DAT_LASTMOD).FirstOrDefault(o => o.BARCODE == barcode);
		}

		private IQueryable<DAT_LOSTEILE> GetItemsWithSkipTake(int? skip, int? take)
		{
			var items = Context.DAT_LOSTEILE.OrderBy(o => o.DAT_LASTMOD).AsQueryable();
			if (skip.HasValue && skip.Value > 0)
				items = items.Skip(skip.Value);
			if (take.HasValue && take.Value > 0)
				items = items.Take(take.Value);
			else
				// safety check to get a maximum #
				items = items.Take(MaxRecordCount);
			return items;
		}

	}
}
