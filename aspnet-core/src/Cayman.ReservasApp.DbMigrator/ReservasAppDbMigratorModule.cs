using Cayman.ReservasApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Cayman.ReservasApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ReservasAppEntityFrameworkCoreModule),
    typeof(ReservasAppApplicationContractsModule)
    )]
public class ReservasAppDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
