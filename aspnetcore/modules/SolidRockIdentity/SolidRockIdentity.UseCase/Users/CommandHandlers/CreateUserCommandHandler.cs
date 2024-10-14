using Dedsi.Ddd.CQRS.CommandHandlers;
using SolidRockIdentity.Repositories.Users;
using SolidRockIdentity.Users.Commands;

namespace SolidRockIdentity.Users.CommandHandlers;

public class CreateUserCommandHandler(IUserRepository userRepository) : DedsiCommandHandler<CreateUserCommand, bool>
{
    public override async Task<bool> Handle(CreateUserCommand command, CancellationToken cancellationToken)
    {
        var user = new User(
            GuidGenerator.Create(),
            command.user.Name,
            command.user.Account,
            command.user.PassWord,
            command.user.Phone,
            command.user.Email,
            command.user.Remark
        );

        // 用户的角色
        var userRoles = command.user.UserRoles.Select(a => new UserRole(user.Id, a.RoleId, a.RoleName)).ToList();
        foreach (var userRole in userRoles)
        {
            user.AddUserRole(userRole);
        }

        // 用户的权限
        var userPermissions = command.user.UserPermissions.Select(a => new UserPermission(user.Id, a.PermissionCode, a.PermissionName, a.Remark)).ToList();
        foreach (var userPermission in userPermissions)
        {
            user.AddUserPermission(userPermission);
        }

        await userRepository.InsertAsync(user, false, cancellationToken);

        return true;
    }
}