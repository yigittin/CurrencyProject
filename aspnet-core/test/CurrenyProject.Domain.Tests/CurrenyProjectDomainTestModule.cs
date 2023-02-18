using CurrenyProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CurrenyProject;

[DependsOn(
    typeof(CurrenyProjectEntityFrameworkCoreTestModule)
    )]
public class CurrenyProjectDomainTestModule : AbpModule
{

}
