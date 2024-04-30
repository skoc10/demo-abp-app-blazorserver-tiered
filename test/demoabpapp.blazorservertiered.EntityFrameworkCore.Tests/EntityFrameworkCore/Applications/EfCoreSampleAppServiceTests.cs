using demoabpapp.blazorservertiered.Samples;
using Xunit;

namespace demoabpapp.blazorservertiered.EntityFrameworkCore.Applications;

[Collection(blazorservertieredTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<blazorservertieredEntityFrameworkCoreTestModule>
{

}
