using System;
using System.Collections.Generic;
using System.Text;
using Cayman.ReservasApp.Localization;
using Volo.Abp.Application.Services;

namespace Cayman.ReservasApp;

/* Inherit your application services from this class.
 */
public abstract class ReservasAppAppService : ApplicationService
{
    protected ReservasAppAppService()
    {
        LocalizationResource = typeof(ReservasAppResource);
    }
}
