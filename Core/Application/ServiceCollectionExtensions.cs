﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
  public static class ServiceCollectionExtensions
  {
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
      return services
              .AddAutoMapper(Assembly.GetExecutingAssembly());
    }
  }
}
