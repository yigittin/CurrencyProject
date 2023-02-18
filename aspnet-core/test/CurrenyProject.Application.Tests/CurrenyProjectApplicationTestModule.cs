using Volo.Abp.Modularity;

namespace CurrenyProject;

[DependsOn(
    typeof(CurrenyProjectApplicationModule),
    typeof(CurrenyProjectDomainTestModule)
    )]
public class CurrenyProjectApplicationTestModule : AbpModule
{

}
