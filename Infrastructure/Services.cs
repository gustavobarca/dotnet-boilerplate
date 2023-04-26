using Domain.Services;
using Infrastructure.Database;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class Services
{
    public static void AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddDbContext<DatabaseContext>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}