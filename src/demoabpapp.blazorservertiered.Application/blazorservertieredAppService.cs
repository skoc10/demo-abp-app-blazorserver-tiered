using demoabpapp.blazorservertiered.Localization;
using Volo.Abp.Application.Services;

namespace demoabpapp.blazorservertiered;

/* Inherit your application services from this class.
 */
public abstract class blazorservertieredAppService : ApplicationService
{
    protected blazorservertieredAppService()
    {
        LocalizationResource = typeof(blazorservertieredResource);
    }
}
