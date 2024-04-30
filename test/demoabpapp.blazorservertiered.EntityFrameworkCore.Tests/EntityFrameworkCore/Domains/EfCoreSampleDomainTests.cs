using demoabpapp.blazorservertiered.Samples;
using Xunit;

namespace demoabpapp.blazorservertiered.EntityFrameworkCore.Domains;

[Collection(blazorservertieredTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<blazorservertieredEntityFrameworkCoreTestModule>
{

}
