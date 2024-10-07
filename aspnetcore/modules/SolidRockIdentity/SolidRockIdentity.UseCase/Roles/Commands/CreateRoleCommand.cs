using Dedsi.Ddd.CQRS.Commands;

namespace SolidRockIdentity.Roles.Commands;

public record CreateRoleCommand(string RoleName, string RoleCode) : DedsiCommand<Guid>;
