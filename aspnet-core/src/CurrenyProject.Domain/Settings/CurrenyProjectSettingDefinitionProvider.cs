using Volo.Abp.Settings;

namespace CurrenyProject.Settings;

public class CurrenyProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CurrenyProjectSettings.MySetting1));
    }
}
