using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

public class Startup
{
    private readonly IConfigurationRoot Configuration;

    public Startup()
    {
        Configuration = new ConfigurationBuilder().Build();
       
    }

    public IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        ConfigureLoggingAndConfigurations(services);

        ConfigureApplicationServices(services);

        IServiceProvider provider = services.BuildServiceProvider();

        return provider;
    }


    private void ConfigureLoggingAndConfigurations(ServiceCollection services)
    {

     
        services.AddSingleton<IConfiguration>(Configuration);

        services.AddLogging(loggingBuilder =>  // AddLogging() requires Microsoft.Extensions.Logging NuGet package
        {
            loggingBuilder.ClearProviders();
            loggingBuilder.AddConsole(); // AddConsole() requires Microsoft.Extensions.Logging.Console NuGet package
        });
    }

    private void ConfigureApplicationServices(ServiceCollection services)
    {
        services.AddTransient<IUpService, UpService>();
    }
}
