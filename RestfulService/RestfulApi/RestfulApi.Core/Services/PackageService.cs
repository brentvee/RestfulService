using System;
using System.Linq;
using RestfulApi.Core.Contracts;
using RestfulApi.Model.Models;

namespace RestfulApi.Core.Services
{
	public class PackageService : ServiceBase, IPackageService
	{
		private IQueryable<DAT_KISTEN> Packages
		{
			get { return Context.DAT_KISTEN.AsQueryable(); }
		}

		public IQueryable<DAT_KISTEN> GetPackagesSince(DateTime since, int? skip, int? take)
		{
			var items = Packages.Where(o => o.DAT_LASTMOD >= since);
			items = SkipAndTake(items, skip, take);
			return items;
		}
	}
}
