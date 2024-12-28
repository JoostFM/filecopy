using Microsoft.Extensions.DependencyInjection;

namespace FileCopy.Wif.Top100Data;

internal static class Top100ServiceCollection
{
    public static IServiceCollection AddTop100ServicesCollection(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
    {
        services.Configure<Top100DataOptions>(configuration.GetSection("Top100Data"));
        services.AddTransient<ITop100_2024DataService, Top100_2024DataService>();
        services.AddTransient<IGoogleSheetsService, GoogleSheetsService>();
        services.AddTransient<IGoogleSheetsHelper, GoogleSheetsHelper>();
        return services;
    }
}
