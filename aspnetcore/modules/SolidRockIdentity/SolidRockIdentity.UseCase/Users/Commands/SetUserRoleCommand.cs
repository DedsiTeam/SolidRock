using Dedsi.Ddd.CQRS.Commands;
using SolidRockIdentity.Roles.Dtos;

namespace SolidRockIdentity.Users.Commands;

/// <summary>
/// 命令：设置用户的角色
/// </summary>
/// <param name="userId"></param>
/// <param name="Roles"></param>
public record SetUserRoleCommand(Guid userId, List<RoleDto> Roles) : DedsiCommand;
