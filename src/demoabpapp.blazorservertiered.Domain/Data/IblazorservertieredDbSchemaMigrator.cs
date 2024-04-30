using System.Threading.Tasks;

namespace demoabpapp.blazorservertiered.Data;

public interface IblazorservertieredDbSchemaMigrator
{
    Task MigrateAsync();
}
