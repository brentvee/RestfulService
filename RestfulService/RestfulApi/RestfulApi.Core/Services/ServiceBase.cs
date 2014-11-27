using System;
using System.Linq;
using Microsoft.Practices.Unity;
using RestfulApi.Model;

namespace RestfulApi.Core.Services
{
	public class ServiceBase : IDisposable
	{
		public const int MaxRecordCount = 2000;
		public IUnityContainer UnityContainer { get; set; }
		protected RestfulDbContext Context = new RestfulDbContext();

		protected ServiceBase()
		{
			
		}

		protected ServiceBase(IUnityContainer unityContainer)
		{
			UnityContainer = unityContainer;
		}

		public void Dispose()
		{
			Context.Dispose();
		}

		protected IQueryable<T> SkipAndTake<T>(IQueryable<T> items, int? skip, int? take)
		{
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