using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Planner.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Planner
{

    public partial class App : Application
    {

        private void OnStartUp(object sender, StartupEventArgs e)
        {
            // Create a collection of services
            IServiceCollection services = new ServiceCollection();

            //Add utility services
            services.AddSingleton(LogFactory<App>.CreateLog);
            services.AddSingleton<Settings>();

            // Add services to the collection and configure them
            services.AddTransient<FirstService>();
            services.AddScoped<MainWindow>();

            // Create a service provider to call the services
            ServiceProvider provider = services.BuildServiceProvider();

            // Initialize Main Window
            MainWindow window = provider.GetService<MainWindow>();
            Logger<App> logger = provider.GetService<Logger<App>>();

            logger.LogInformation("Test");
            window.Show();
        }
    }
}
