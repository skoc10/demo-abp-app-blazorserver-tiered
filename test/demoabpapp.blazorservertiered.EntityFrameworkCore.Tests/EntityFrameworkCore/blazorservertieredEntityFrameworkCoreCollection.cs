using Xunit;

namespace demoabpapp.blazorservertiered.EntityFrameworkCore;

[CollectionDefinition(blazorservertieredTestConsts.CollectionDefinitionName)]
public class blazorservertieredEntityFrameworkCoreCollection : ICollectionFixture<blazorservertieredEntityFrameworkCoreFixture>
{

}
