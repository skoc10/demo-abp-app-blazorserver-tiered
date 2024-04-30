using Volo.Abp.Modularity;

namespace demoabpapp.blazorservertiered;

[DependsOn(
    typeof(blazorservertieredDomainModule),
    typeof(blazorservertieredTestBaseModule)
)]
public class blazorservertieredDomainTestModule : AbpModule
{

}
