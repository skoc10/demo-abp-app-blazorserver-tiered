using demoabpapp.blazorservertiered.Localization;
using Volo.Abp.AspNetCore.Components;

namespace demoabpapp.blazorservertiered.Blazor;

public abstract class blazorservertieredComponentBase : AbpComponentBase
{
    protected blazorservertieredComponentBase()
    {
        LocalizationResource = typeof(blazorservertieredResource);
    }
}
