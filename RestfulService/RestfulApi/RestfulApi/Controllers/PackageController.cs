using System.Collections;
using System.Linq;
using System.Web.Http;
using RestfulApi.Core.Contracts;
using RestfulApi.Model.Models;

namespace RestfulApi.Controllers
{
    public class PackageController : ApiController
    {
		public IPackageService PackageService { get; set; }
	    //public IUnityContainer Container { get; set; }

		public PackageController(IPackageService packageService)
	    {
		    PackageService = packageService;
	    }

		// example :/api/item/GetItem?barcode=1
		[HttpGet]
		public DAT_KISTEN GetPackage(string barcode)
		{
			return PackageService.GetPackageByBarcode(barcode);
		}

		// example :/api/item/GetAllItems?barcode=1&skip=10&take=10
		[HttpGet]
		public IEnumerable GetAllPackages(string barcode,int? skip = null, int? take = null)
		{
			return PackageService.GetPackagesByBarcode(barcode, skip, take).ToList();
		}
    }
}
