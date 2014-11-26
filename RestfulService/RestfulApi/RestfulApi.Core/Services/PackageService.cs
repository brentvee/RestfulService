using System.Linq;
using Microsoft.Practices.Unity;
using RestfulApi.Core.Contracts;
using RestfulApi.Model.Models;

namespace RestfulApi.Core.Services
{
	public class PackageService : ServiceBase, IPackageService
	{

		public IQueryable<DAT_KISTEN> GetPackagesByBarcode(string barcode, int? skip, int? take)
		{
			var items = GetPackagesWithSkipTake(skip, take);
			items = items.Where(o => o.BARCODE == barcode);
			return items;
		}

		public DAT_KISTEN GetPackageByBarcode(string barcode)
		{
			return Context.DAT_KISTEN.OrderByDescending(o => o.DAT_LASTMOD).FirstOrDefault(o => o.BARCODE == barcode);
		}

		private IQueryable<DAT_KISTEN> GetPackagesWithSkipTake(int? skip, int? take)
		{
			var items = Context.DAT_KISTEN.OrderBy(o => o.DAT_LASTMOD).AsQueryable();
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
