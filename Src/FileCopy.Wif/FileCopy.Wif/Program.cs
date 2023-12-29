using FileCopy.Wif;
using Microsoft.Extensions.Configuration;

public class Program
{
    public static IConfiguration Configuration { get; set; }

    [STAThread]
    static void Main()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        Configuration = builder.Build();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
    }
}
