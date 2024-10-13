using Dedsi.Ddd.CQRS.CommandHandlers;
using SolidRockIdentity.Permissions.Commands;
using SolidRockIdentity.Repositories.Permissions;

namespace SolidRockIdentity.Permissions.CommandHandlers;

public class UpdatePermissionCommandHandler(IPermissionRepository permissionRepository) : DedsiCommandHandler<UpdatePermissionCommand, bool>
{
    public override async Task<bool> Handle(UpdatePermissionCommand command, CancellationToken cancellationToken)
    {
        var domain = await permissionRepository.GetAsync(a => a.Id == command.id);
        
        domain.ChangeCode(command.CreateUpdatePermissionDto.Code);
        domain.ChangeName(command.CreateUpdatePermissionDto.Name);
        domain.ChangeRemark(command.CreateUpdatePermissionDto.Remark);

        await permissionRepository.UpdateAsync(domain, false, cancellationToken);

        return true;
    }
}