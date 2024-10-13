using Dedsi.Ddd.CQRS.CommandHandlers;
using SolidRockIdentity.Permissions.Commands;
using SolidRockIdentity.Repositories.Permissions;

namespace SolidRockIdentity.Permissions.CommandHandlers;

public class UpdatePermissionCommandHandler(IPermissionRepository permissionRepository) : DedsiCommandHandler<UpdatePermissionCommand, bool>
{
    public override async Task<bool> Handle(UpdatePermissionCommand command, CancellationToken cancellationToken)
    {
        var permission = await permissionRepository.GetAsync(a => a.Id == command.id, true, cancellationToken);
        
        permission.ChangeCode(command.permission.Code);
        permission.ChangeName(command.permission.Name);
        permission.ChangeRemark(command.permission.Remark);

        await permissionRepository.UpdateAsync(permission, false, cancellationToken);

        return true;
    }
}