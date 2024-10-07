using Dedsi.Ddd.CQRS.CommandHandlers;
using SolidRockIdentity.Repositories.Roles;
using SolidRockIdentity.Repositories.Users;
using SolidRockIdentity.Users.Commands;
using Volo.Abp.Guids;

namespace SolidRockIdentity.Users.CommandHandlers;

/// <summary>
/// CreateUserCommand 处理处理器
/// </summary>
/// <param name="userRepository"></param>
/// <param name="roleRepository"></param>
/// <param name="guidGenerator"></param>
public class CreateUserCommandHandler(
    IUserRepository userRepository,
    IRoleRepository roleRepository,
    IGuidGenerator guidGenerator)
    : DedsiCommandHandler<CreateUserCommand, Guid>
{
    public override async Task<Guid> Handle(CreateUserCommand command, CancellationToken cancellationToken)
    {
        // 普通用户角色
        var role = await roleRepository.GetAsync(a => a.RoleCode == "OrdinaryUser");

        // 创建用户
        var user = new User(guidGenerator.Create(), command.UserName, command.Account, "PassWork@" + DateTime.Now.Year, command.Email, role);

        // 保存到数据库
        await userRepository.InsertAsync(user);

        return user.Id;
    }
}