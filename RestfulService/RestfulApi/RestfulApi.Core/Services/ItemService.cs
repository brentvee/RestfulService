using System;
using System.Linq;
using RestfulApi.Core.Contracts;
using RestfulApi.Model.Models;

namespace RestfulApi.Core.Services
{
	public class ItemService : ServiceBase, IItemService
	{
		private IQueryable<DAT_LOSTEILE> Items
		{
			get { return Context.DAT_LOSTEILE.AsQueryable(); }
		}

		public IQueryable<DAT_LOSTEILE> GetItemsSince(DateTime since, int? skip, int? take)
		{
			var items = Items.Where(o => o.DAT_LASTMOD >= since);
			items = SkipAndTake(items, skip, take);
			return items;
		}
	}
}
