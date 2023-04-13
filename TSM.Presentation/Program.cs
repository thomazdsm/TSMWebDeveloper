using Microsoft.Extensions.DependencyInjection;
using TSM.Infra.IoC;

namespace TSMWebDeveloper
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddInfrastructure();

            var serviceProvider = services.BuildServiceProvider();

            DependencyInjection.MigrateDatabase(serviceProvider);

            Application.Run(new StartForm(serviceProvider));
        }
    }
}
