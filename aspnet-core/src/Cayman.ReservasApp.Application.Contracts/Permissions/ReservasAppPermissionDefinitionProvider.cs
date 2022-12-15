using Cayman.ReservasApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Cayman.ReservasApp.Permissions;

public class ReservasAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ReservasAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ReservasAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ReservasAppResource>(name);
    }
}
