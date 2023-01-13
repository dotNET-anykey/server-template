using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RageMP.Infrastructure;
using RageMP.Infrastructure.Repositories;
using RageMP.Infrastructure.Repositories.Interfaces;
using RageMP.Server.Services;
using RageMP.Server.Services.Interfaces;

namespace RageMP.Server
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
