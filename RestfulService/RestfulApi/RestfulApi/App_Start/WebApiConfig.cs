using System;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using Microsoft.Practices.Unity;
using RestfulApi.Core.Contracts;
using RestfulApi.Core.Services;
using Unity.WebApi;

namespace RestfulApi
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				//routeTemplate :"api/{controller}/{action}/{id}",
				defaults: new {id = RouteParameter.Optional}
				);


			

			config.Formatters.Add(new BrowserJsonFormatter());

			
		}
	}

	public class BrowserJsonFormatter : JsonMediaTypeFormatter
	{
		public BrowserJsonFormatter()
		{
			this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
		}

		public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
		{
			base.SetDefaultContentHeaders(type, headers, mediaType);
			headers.ContentType = new MediaTypeHeaderValue("application/json");
		}
	}
}