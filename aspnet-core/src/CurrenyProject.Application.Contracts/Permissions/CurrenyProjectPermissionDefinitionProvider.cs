using CurrenyProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CurrenyProject.Permissions;

public class CurrenyProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CurrenyProjectPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CurrenyProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CurrenyProjectResource>(name);
    }
}
