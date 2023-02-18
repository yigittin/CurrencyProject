using System.Threading.Tasks;

namespace CurrenyProject.Data;

public interface ICurrenyProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
