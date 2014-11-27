using System;
using System.Linq;
using RestfulApi.Model.Models;

namespace RestfulApi.Core.Contracts
{
	public interface IPackageService
	{
		IQueryable<DAT_KISTEN> GetPackagesSince(DateTime since, int? skip, int? take);
	}
}
