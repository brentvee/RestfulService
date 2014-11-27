using System;
using System.Linq;
using RestfulApi.Model.Models;

namespace RestfulApi.Core.Contracts
{
	public interface IItemService
	{
		IQueryable<DAT_LOSTEILE> GetItemsSince(DateTime since, int? skip, int? take);
	}
}
