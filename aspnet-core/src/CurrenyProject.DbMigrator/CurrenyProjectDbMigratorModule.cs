using CurrenyProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CurrenyProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CurrenyProjectEntityFrameworkCoreModule),
    typeof(CurrenyProjectApplicationContractsModule)
    )]
public class CurrenyProjectDbMigratorModule : AbpModule
{

}
