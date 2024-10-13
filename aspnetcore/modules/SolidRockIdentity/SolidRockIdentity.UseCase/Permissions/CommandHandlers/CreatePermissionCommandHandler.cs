using Dedsi.Ddd.CQRS.CommandHandlers;
using SolidRockIdentity.Permissions.Commands;
using SolidRockIdentity.Repositories.Permissions;

namespace SolidRockIdentity.Permissions.CommandHandlers;

public class CreatePermissionCommandHandler(IPermissionRepository permissionRepository) : DedsiCommandHandler<CreatePermissionCommand, bool>
{
    public override async Task<bool> Handle(CreatePermissionCommand command, CancellationToken cancellationToken)
    {
        var permission = new Permission(
            GuidGenerator.Create(),
            command.CreateUpdatePermissionDto.Code,
            command.CreateUpdatePermissionDto.Name,
            command.CreateUpdatePermissionDto.Remark
            );
        await permissionRepository.InsertAsync(permission, false, cancellationToken);

        return true;
    }
}