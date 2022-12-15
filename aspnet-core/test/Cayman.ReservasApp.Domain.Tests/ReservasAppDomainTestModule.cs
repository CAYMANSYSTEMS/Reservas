using Cayman.ReservasApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Cayman.ReservasApp;

[DependsOn(
    typeof(ReservasAppEntityFrameworkCoreTestModule)
    )]
public class ReservasAppDomainTestModule : AbpModule
{

}
