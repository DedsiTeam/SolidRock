using Dedsi.Ddd.CQRS.CommandHandlers;
using SolidRockIdentity.Repositories.Users;
using SolidRockIdentity.Users.Commands;

namespace SolidRockIdentity.Users.CommandHandlers;

public class UpdateUserCommandHandler(IUserRepository userRepository): DedsiCommandHandler<UpdateUserCommand, bool>
{
    public override async Task<bool> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
    {
        var user = await userRepository.GetAsync(a => a.Id == command.user.Id);
        
        user.ChangeName(command.user.Name);
        user.ChangeAccount(command.user.Account);
        user.ChangePassWord(command.user.PassWord);
        user.ChangePhone(command.user.Phone);
        user.ChangeEmail(command.user.Email);
        user.ChangeRemark(command.user.Remark);
        
        // 用户的角色
        user.ClearUserRoles();
        var userRoles = command.user.UserRoles.Select(a => new UserRole(user.Id, a.RoleId, a.RoleName)).ToList();
        foreach (var userRole in userRoles)
        {
            user.AddUserRole(userRole);
        }

        // 用户的权限
        user.ClearUserPermissions();
        var userPermissions = command.user.UserPermissions.Select(a => new UserPermission(user.Id, a.PermissionCode, a.PermissionName, a.Remark)).ToList();
        foreach (var userPermission in userPermissions)
        {
            user.AddUserPermission(userPermission);
        }
        
        await userRepository.UpdateAsync(user, false, cancellationToken);

        return true;
    }
}