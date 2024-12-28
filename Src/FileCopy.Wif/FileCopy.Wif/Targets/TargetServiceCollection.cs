using Microsoft.Extensions.DependencyInjection;

namespace FileCopy.Wif.Targets;

public static class TargetServiceCollection
{
    public static IServiceCollection AddTargetServicesCollection(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
    {
        services.Configure<ArtworkSettingsOptions>(configuration.GetSection("ArtworkSettings"));
        services.AddTransient<IArtworkTargetService, ArtworkTargetService>();
        return services;
    }
}
