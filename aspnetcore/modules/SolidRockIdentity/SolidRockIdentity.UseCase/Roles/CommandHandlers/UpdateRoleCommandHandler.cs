using Dedsi.Ddd.CQRS.CommandHandlers;
using SolidRockIdentity.Repositories.Roles;
using SolidRockIdentity.Roles.Commands;

namespace SolidRockIdentity.Roles.CommandHandlers;

public class UpdateRoleCommandHandler(IRoleRepository roleRepository) : DedsiCommandHandler<UpdateRoleCommand, bool>
{
    public override async Task<bool> Handle(UpdateRoleCommand command, CancellationToken cancellationToken)
    {
        var role = await roleRepository.GetAsync(a => a.Id == command.role.Id, true, cancellationToken);
        role.ChangeName(command.role.Name);
        role.ChangeRemark(command.role.Remark);
        
        // RolePermissions
        role.ClearRolePermissions();
        var rolePermissions = command.role
            .RolePermissions
            .Select(a => new RolePermission(role.Id, a.PermissionCode, a.PermissionName, a.Remark))
            .ToList();
        foreach (var rolePermission in rolePermissions)
        {
            role.AddRolePermission(rolePermission);
        }
        
        await roleRepository.UpdateAsync(role, false, cancellationToken);

        return true;
    }
}