using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Cayman.ReservasApp;

[Dependency(ReplaceServices = true)]
public class ReservasAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ReservasApp";
}
