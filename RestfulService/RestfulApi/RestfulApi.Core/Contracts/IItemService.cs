using System.Linq;
using RestfulApi.Model.Models;

namespace RestfulApi.Core.Contracts
{
	public interface IItemService
	{
		IQueryable<DAT_LOSTEILE> GetItemsByBarcode(string barcode, int? skip, int? take);
		DAT_LOSTEILE GetItemByBarcode(string barcode);
	}
}
