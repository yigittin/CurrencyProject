using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CurrenyProject;

[Dependency(ReplaceServices = true)]
public class CurrenyProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CurrenyProject";
}
