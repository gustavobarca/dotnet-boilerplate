using Application;

namespace Web;

public static class Services
{
    public static void AddWebServices(this IServiceCollection services)
    {
        services.AddScoped<UserService>();
        services.AddScoped<BasketService>();
    }
}