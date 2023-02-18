using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CurrenyProject.Data;

/* This is used if database provider does't define
 * ICurrenyProjectDbSchemaMigrator implementation.
 */
public class NullCurrenyProjectDbSchemaMigrator : ICurrenyProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
