using EndPoint.Forms;
using ApplicationIT.Database;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using ApplicationIT.Service.ComputerList;
using ApplicationIT.Service.HardwareService.HardwareBrand;
using ApplicationIT.Service.HardwareService.HardwareDetail;
using ApplicationIT.Service.HardwareService.SaveService;
using ApplicationIT.Service.HardwareService.ShowHardware;
using ApplicationIT.Service.HardwareService.HardwareHistory;
using ApplicationIT.Service.User.AssignUserToComputer;
using ApplicationIT.Service.User.ShowUser;
using ApplicationIT.Service.User.UserComputerHistoryService;
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
            services.AddScoped<IHardwareBrands , HardwareBrands>();
            services.AddScoped<IComputerHardwareSaveService, ComputerHardwareSaveService>();
            services.AddScoped<IComputerHardwareQueryService, ComputerHardwareQueryService>();
            services.AddScoped<IHardwareDetails, HardwareDetails>();
            services.AddScoped<IUserHistoryService, UserHistoryService>();
            services.AddScoped<IComputerHardwareHistoryService, ComputerHardwareHistoryService>();
            services.AddScoped<IUserComputerAssignService, UserComputerAssignService>();
            services.AddTransient<IComputerList, ComputerListService>();
            services.AddTransient<IHardwareBrands, HardwareBrands>();
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
            var HardwareDetails = (IHardwareDetails)ServiceProvider.GetService(typeof(IHardwareDetails));
            var serviceGetList = (IUserShowService)ServiceProvider.GetService(typeof(IUserShowService));
            var ComputerList = (IComputerList)ServiceProvider.GetService(typeof(IComputerList));
            var HardwareBrands = (IHardwareBrands)ServiceProvider.GetService(typeof(IHardwareBrands));

            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain(serviceGetList , database , ComputerList , HardwareBrands ));
        }
    }
}