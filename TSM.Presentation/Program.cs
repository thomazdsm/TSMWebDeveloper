using Microsoft.EntityFrameworkCore;
using System.Configuration;
using TSM.Infra.Data.Context;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 32)));

            using (var context = new ApplicationDbContext())
            {
                context.Database.Migrate();
            }

            // Configura o DbContextOptions
            //var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            //    .UseMySql("server=localhost;initial catalog=wf_tsm;uid=root;pwd=",
            //    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"))
            //    .Options;

            // Cria a instância do ApplicationDbContext com o DbContextOptions
            //var dbContext = new ApplicationDbContext(options);

            // Para utilizar o dbContext, você pode passá-lo para o construtor da sua form
            Application.Run(new StartForm());
        }
    }
}