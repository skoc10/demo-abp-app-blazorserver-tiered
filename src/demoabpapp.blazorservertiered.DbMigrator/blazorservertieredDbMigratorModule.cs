using demoabpapp.blazorservertiered.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;

namespace demoabpapp.blazorservertiered.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(blazorservertieredEntityFrameworkCoreModule),
    typeof(blazorservertieredApplicationContractsModule)
)]
public class blazorservertieredDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "blazorservertiered:"; });
    }
}
