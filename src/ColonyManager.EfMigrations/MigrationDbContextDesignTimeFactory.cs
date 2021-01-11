using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Reflection;

namespace ColonyManager.EfMigrations
{
    public class MigrationDbContextDesignTimeFactory : IDesignTimeDbContextFactory<MigrationDbContext>
    {
        public MigrationDbContext CreateDbContext(string[] args)
        {
            string connectionString = null;
            if (args != null && args.Length > 0)
            {
                connectionString = args[0];
            }

            var builder = CreateDbContextOptionsBuilder(connectionString);

            return new MigrationDbContext(builder.Options);
        }

        private DbContextOptionsBuilder<MigrationDbContext> CreateDbContextOptionsBuilder(string connectionString)
        {

            var builder = new DbContextOptionsBuilder<MigrationDbContext>();

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                var configuration = new ConfigurationBuilder()
                 .SetBasePath(new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName)
                 .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                 .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? string.Empty}.json", optional: true)
                 .AddEnvironmentVariables()
                 .Build();

                connectionString = configuration.GetConnectionString("DefaultConnection");
            }

            builder.UseSqlServer(connectionString,
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null);
                });

            builder.EnableSensitiveDataLogging(true);

            return builder;
        }
    }
}
