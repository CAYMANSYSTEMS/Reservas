using Cayman.ReservasApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Cayman.ReservasApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ReservasAppController : AbpControllerBase
{
    protected ReservasAppController()
    {
        LocalizationResource = typeof(ReservasAppResource);
    }
}
