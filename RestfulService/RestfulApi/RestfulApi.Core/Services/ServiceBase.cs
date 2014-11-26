using System;
using Microsoft.Practices.Unity;
using RestfulApi.Model;

namespace RestfulApi.Core.Services
{
	public class ServiceBase : IDisposable
	{
		public const int MaxRecordCount = 2000;
		public IUnityContainer UnityContainer { get; set; }
		protected RestfulDbContext Context = new RestfulDbContext();

		protected ServiceBase(IUnityContainer unityContainer)
		{
			UnityContainer = unityContainer;
		}

		protected ServiceBase()
		{
			
		}

		public void Dispose()
		{
			Context.Dispose();
		}
	}
}