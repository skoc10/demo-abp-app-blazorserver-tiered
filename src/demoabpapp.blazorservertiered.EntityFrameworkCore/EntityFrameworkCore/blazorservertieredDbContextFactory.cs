using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace demoabpapp.blazorservertiered.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class blazorservertieredDbContextFactory : IDesignTimeDbContextFactory<blazorservertieredDbContext>
{
    public blazorservertieredDbContext CreateDbContext(string[] args)
    {
        blazorservertieredEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<blazorservertieredDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new blazorservertieredDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../demoabpapp.blazorservertiered.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
