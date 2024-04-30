using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using demoabpapp.blazorservertiered.Data;
using Volo.Abp.DependencyInjection;

namespace demoabpapp.blazorservertiered.EntityFrameworkCore;

public class EntityFrameworkCoreblazorservertieredDbSchemaMigrator
    : IblazorservertieredDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreblazorservertieredDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the blazorservertieredDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<blazorservertieredDbContext>()
            .Database
            .MigrateAsync();
    }
}
