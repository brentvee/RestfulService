using Microsoft.Practices.Unity;
using System.Web.Http;
using RestfulApi.Core.Contracts;
using RestfulApi.Core.Services;
using Unity.WebApi;

namespace RestfulApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
	        container.RegisterType<IItemService, ItemService>(new HierarchicalLifetimeManager());
			container.RegisterType<IPackageService, PackageService>(new HierarchicalLifetimeManager());
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}