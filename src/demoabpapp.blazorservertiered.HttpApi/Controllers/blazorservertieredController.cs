using demoabpapp.blazorservertiered.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace demoabpapp.blazorservertiered.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class blazorservertieredController : AbpControllerBase
{
    protected blazorservertieredController()
    {
        LocalizationResource = typeof(blazorservertieredResource);
    }
}
