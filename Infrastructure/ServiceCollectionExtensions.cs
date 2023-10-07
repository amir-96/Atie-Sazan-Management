using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
  public static class ServiceCollectionExtensions
  {
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
      return services
              .AddDbContext<ApplicationDbContext>(opt =>
              {
                opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
              });
    }
  }
}
