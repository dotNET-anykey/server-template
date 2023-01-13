using Infrastructure;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Server.Services;
using Server.Services.Interfaces;

namespace Server
{
    public static class ServicesContainer
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static void Init()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(RegisterServices)
                .Build();

            ServiceProvider = host.Services;

            using (var serviceScope = host.Services.CreateScope())
            {
                var databaseContext = serviceScope.ServiceProvider.GetRequiredService<DatabaseContext>();
                databaseContext.Database.Migrate();
            }

            host.Start();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IService, Service>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRepository, Repository>();

            services.AddDbContext<DatabaseContext>();
        }
    }
}
