using ConsoleApp.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp
{
    /// <summary>
    /// Startup service registeration routines
    /// </summary>
    public class Startup
    {
        private readonly IConfiguration _configuration;

        /// <summary>
        /// The Startip constructor
        /// </summary>
        /// <param name="configuration">A configuration object</param>
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Dependency Injection services are registered in this method
        /// </summary>
        /// <param name="services">The service collection</param>
        public void ConfigureServices(IServiceCollection services)
        {
            // The IApplication interface must be registered for the application to worl
            services.AddTransient<IApplication, ConsoleApp>();

            // Example configuration binding
            var appOptions = _configuration.GetSection(nameof(ApplicationOptions))
                .Get<ApplicationOptions>();

            services.AddSingleton(appOptions);
        }
    }
}
