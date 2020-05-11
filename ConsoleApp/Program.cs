using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace ConsoleApp
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var configuration = BuildConfiguration(args);

            var serviceCollection = new ServiceCollection();
            var startUp = new Startup(configuration);

            startUp.ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider.GetRequiredService<IApplication>()
                .Execute(args);
        }

        private static IConfiguration BuildConfiguration(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddCommandLine(args);

            return builder.Build();
        }
    }
}
