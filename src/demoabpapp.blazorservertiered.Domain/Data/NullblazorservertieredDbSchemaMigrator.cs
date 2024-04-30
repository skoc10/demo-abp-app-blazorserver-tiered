using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace demoabpapp.blazorservertiered.Data;

/* This is used if database provider does't define
 * IblazorservertieredDbSchemaMigrator implementation.
 */
public class NullblazorservertieredDbSchemaMigrator : IblazorservertieredDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
