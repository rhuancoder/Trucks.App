using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Trucks.Domain.Entities;

namespace Trucks.Repository.Contexts
{
    public class TrucksDBContext : DbContext
    {
        private IConfiguration _configuration;
        private const string _sqliteConnection = "SqliteConnection";

        public TrucksDBContext(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }

        public TrucksDBContext(DbContextOptions<TrucksDBContext> options, IConfiguration Configuration) : base(options)
        {
            _configuration = Configuration;
        }

        public DbSet<Truck>? Trucks { get; set; }
        public DbSet<TruckModel>? TrucksModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlite(_configuration.GetConnectionString(_sqliteConnection))
            .LogTo(Console.WriteLine, LogLevel.Information)
            .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(typeof(TrucksDBContext).Assembly);

        public override void Dispose() => base.Dispose();
    }
}