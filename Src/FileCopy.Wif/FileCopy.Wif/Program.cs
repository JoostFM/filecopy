using FileCopy.Wif;
using FileCopy.Wif.Targets;
using FileCopy.Wif.Top100Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.IO.Abstractions;

internal class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        IConfiguration configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", false)
               .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true) //load local settings
               .Build();

        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.File(@"../../logs/log-.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        IHostBuilder CreateHostBuilder(string[] args) =>
               Host.CreateDefaultBuilder(args)
               .UseSerilog((hostingContext, loggerConfiguration) =>
                   loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration))
               .ConfigureServices((hostContext, services) =>
               {
                   services.AddTop100ServicesCollection(configuration);
                   services.AddTargetServicesCollection(configuration);
                   services.AddTransient<IFileSystem, FileSystem>();
                   services.AddTransient<Form1>();
               });

        var host = CreateHostBuilder(args).Build();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var mainForm = host.Services.GetRequiredService<Form1>();

        Application.Run(mainForm);
    }
}
