using System;
using System.Collections;
using System.Linq;
using System.Web.Http;
using RestfulApi.Core.Contracts;

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

		// example :/api/item/barcode=1
		/*[HttpGet]
		public DAT_KISTEN GetPackage(string barcode)
		{
			return PackageService.GetPackageByBarcode(barcode);
		}*/

		// example :/api/package?since=2014-01-01&skip=10&take=10
		[HttpGet]
		public IEnumerable GetPackagesSince(DateTime since, int? skip = null, int? take = null)
		{
			return PackageService.GetPackagesSince(since, skip, take).ToList();
		}
    }
}
