using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace RageMP.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = "User ID =postgres;Host=localhost;Port=5432;Database=;Password=123;";

            optionsBuilder.UseNpgsql(connectionString, sqlOptions =>
            {
                sqlOptions.EnableRetryOnFailure(
                    10,
                    TimeSpan.FromSeconds(30),
                    null);
            });

            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}