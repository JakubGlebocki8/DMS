using DMS.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DMS.Infrastructure.Extensions;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DMSDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DbConnectionString")));
        services.AddTransient<IDmsRepository, DmsRepository>();
        return services;
    }
}
