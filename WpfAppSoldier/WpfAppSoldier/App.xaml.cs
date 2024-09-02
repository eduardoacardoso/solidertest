using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Configuration;
using System.Data;
using System.Windows;
using WpfSoldier.Application.Interface;
using WpfSoldier.Domain.Entities;
using WpfSoldier.Infrastructure.DataContext;
using WpfSoldier.Infrastructure.Repository;
using ISensorSimulationService = WpfSoldier.Application.Interface.ISensorSimulationService;

namespace WpfAppSoldier
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _serviceProvider;

        public App()
        {
            // Configure the DI container here
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            //Register DataContext
            services.AddDbContext<SoldierDataContext>(options =>
                options.UseSqlServer("Data Source=DESKTOP-IGQP4QF\\SQLEXPRESS;Initial Catalog=SoldierData;user id=sa;password=123456q!; Integrated Security=True;TrustServerCertificate=True;"));

            // Register 
            services.AddSingleton<MainWindow>(); 
            services.AddScoped<IGenericRepository<Soldier>, GenericRepository<Soldier>>();
            services.AddScoped<IGenericRepository<Position>, GenericRepository<Position>>();
            services.AddScoped<IGenericRepository<Training>, GenericRepository<Training>>();
            services.AddScoped<IGenericRepository<Sensor>, GenericRepository<Sensor>>();

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }

}
