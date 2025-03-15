using EndPoint.Forms;
using ApplicationIT.Database;
using ApplicationIT.Service.UserService;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
namespace EndPoint
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IDatabaseContext, DatabaseContext>();
            services.AddScoped<IUserShowService, UserShowService>();
            ServiceProvider = services.BuildServiceProvider();
        }
        [STAThread]
        static void Main()
        {
            ConfigureServices();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var database = (IDatabaseContext)ServiceProvider.GetService(typeof(IDatabaseContext));
            var serviceGetList = (IUserShowService)ServiceProvider.GetService(typeof(IUserShowService));
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain(serviceGetList , database));
        }
    }
}