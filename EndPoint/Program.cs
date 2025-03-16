using EndPoint.Forms;
using ApplicationIT.Database;
using ApplicationIT.Service.UserService;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using ApplicationIT.Service.ComputerList;
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
            services.AddScoped<IComputerList , ComputerListService>();
            services.AddTransient<IComputerList, ComputerListService>();
            services.AddTransient<FrmComputerList>();
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
            var ComputerList = (IComputerList)ServiceProvider.GetService(typeof(IComputerList));
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain(serviceGetList , database , ComputerList));
        }
    }
}