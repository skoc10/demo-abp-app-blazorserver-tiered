using Volo.Abp.Modularity;

namespace demoabpapp.blazorservertiered;

public abstract class blazorservertieredApplicationTestBase<TStartupModule> : blazorservertieredTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
