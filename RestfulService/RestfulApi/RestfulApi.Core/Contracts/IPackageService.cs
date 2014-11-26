using System.Linq;
using RestfulApi.Model.Models;

namespace RestfulApi.Core.Contracts
{
	public interface IPackageService
	{
		IQueryable<DAT_KISTEN> GetPackagesByBarcode(string barcode, int? skip, int? take);
		DAT_KISTEN GetPackageByBarcode(string barcode);
	}
}
