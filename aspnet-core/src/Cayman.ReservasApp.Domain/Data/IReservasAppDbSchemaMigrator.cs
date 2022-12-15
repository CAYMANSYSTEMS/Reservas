using System.Threading.Tasks;

namespace Cayman.ReservasApp.Data;

public interface IReservasAppDbSchemaMigrator
{
    Task MigrateAsync();
}
