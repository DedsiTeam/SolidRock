using Dedsi.Ddd.CQRS.CommandHandlers;
using SolidRockIdentity.Permissions.Commands;
using SolidRockIdentity.Repositories.Permissions;

namespace SolidRockIdentity.Permissions.CommandHandlers;

public class DeletePermissionCommandHandler(IPermissionRepository permissionRepository) : DedsiCommandHandler<DeletePermissionCommand, bool>
{
    public override async Task<bool> Handle(DeletePermissionCommand command, CancellationToken cancellationToken)
    {
        await permissionRepository.DeleteAsync(a => a.Id == command.id, false, cancellationToken);

        return true;
    }
}