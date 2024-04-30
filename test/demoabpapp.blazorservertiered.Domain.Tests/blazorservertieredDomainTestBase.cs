using Volo.Abp.Modularity;

namespace demoabpapp.blazorservertiered;

/* Inherit from this class for your domain layer tests. */
public abstract class blazorservertieredDomainTestBase<TStartupModule> : blazorservertieredTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
