using Dedsi.Ddd.CQRS.Commands;
using SolidRockIdentity.Roles.Dtos;

namespace SolidRockIdentity.Roles.Commands;

public record CreateRoleCommand(RoleDto role) : DedsiCommand<bool>;

public record UpdateRoleCommand(RoleDto role) : DedsiCommand<bool>;

public record DeleteRoleCommand(Guid id) : DedsiCommand<bool>;