using System;
using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace GameNews.ApplicationCore
{
	public static class ConfigureServices
	{
		public static IServiceCollection AddGameNewsApplication(this IServiceCollection service)
		{
            //Adding Mediatr
            service.AddMediatR(Assembly.GetExecutingAssembly());
			return service;
        }

	}
}

