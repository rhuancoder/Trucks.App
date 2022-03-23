using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Trucks.Business.Services;
using Trucks.Domain.Contracts.Repositories;
using Trucks.Domain.Contracts.Services;
using Trucks.Repository.Contexts;
using Trucks.Repository.Repositories;

namespace Trucks.IoC
{
    public static class NativeInjectorConfiguration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ITruckService, TruckService>();
        }

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITruckRepository, TruckRepository>();
            services.AddScoped<ITruckModelRepository, TruckModelRepository>();
        }

        public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TrucksDBContext>();

            using var db = new TrucksDBContext(configuration);

            //db.Database.Migrate();
        }
    }
}