using Microsoft.Extensions.DependencyInjection;
using SportWinFormsApp1.Data;
using SportWinFormsApp1.Servises;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SportWinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            services.AddDbContext<WorkoutContext>(options =>
                options.UseSqlite("Data Source=workouts.db"));

            services.AddTransient<WorkoutService>();
            services.AddTransient<FormMain>();

            using var serviceProvider = services.BuildServiceProvider();

            var form = serviceProvider.GetRequiredService<FormMain>();

            Application.Run(form);

        }
    }
}