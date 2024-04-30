using Volo.Abp.Modularity;

namespace demoabpapp.blazorservertiered;

[DependsOn(
    typeof(blazorservertieredApplicationModule),
    typeof(blazorservertieredDomainTestModule)
)]
public class blazorservertieredApplicationTestModule : AbpModule
{

}
