using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Cayman.ReservasApp.Data;

/* This is used if database provider does't define
 * IReservasAppDbSchemaMigrator implementation.
 */
public class NullReservasAppDbSchemaMigrator : IReservasAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
