using Volo.Abp.Modularity;

namespace Cayman.ReservasApp;

[DependsOn(
    typeof(ReservasAppApplicationModule),
    typeof(ReservasAppDomainTestModule)
    )]
public class ReservasAppApplicationTestModule : AbpModule
{

}
