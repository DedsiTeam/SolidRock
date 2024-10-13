using Dedsi.Ddd.CQRS.CommandHandlers;
using SolidRockIdentity.Repositories.Roles;
using SolidRockIdentity.Roles.Commands;

namespace SolidRockIdentity.Roles.CommandHandlers;

public class CreateRoleCommandHandler(IRoleRepository roleRepository) : DedsiCommandHandler<CreateRoleCommand, bool>
{
    public override async Task<bool> Handle(CreateRoleCommand command, CancellationToken cancellationToken)
    {
        var role = new Role(GuidGenerator.Create(),command.role.Name, command.role.Remark);
        
        // RolePermissions
        var rolePermissions = command.role
            .RolePermissions
            .Select(a => new RolePermission(role.Id, a.PermissionCode, a.PermissionName, a.Remark))
            .ToList();

        foreach (var rolePermission in rolePermissions)
        {
            role.AddRolePermission(rolePermission);
        }
        
        await roleRepository.InsertAsync(role, false, cancellationToken);

        return true;
    }
}