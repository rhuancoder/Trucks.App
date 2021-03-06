using Microsoft.EntityFrameworkCore;
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
            services.AddScoped<ITruckModelService, TruckModelService>();
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITruckRepository, TruckRepository>();
            services.AddScoped<ITruckModelRepository, TruckModelRepository>();
        }

        public static void RegisterDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TrucksDBContext>();

            using var db = new TrucksDBContext(configuration);

            db.Database.Migrate();
        }
    }
}