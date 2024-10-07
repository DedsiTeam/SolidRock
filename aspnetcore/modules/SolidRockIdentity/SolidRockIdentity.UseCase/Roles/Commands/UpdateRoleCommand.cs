using Dedsi.Ddd.CQRS.Commands;

namespace SolidRockIdentity.Roles.Commands;

public record UpdateRoleCommand(Guid id,string RoleName, string RoleCode) : DedsiCommand<bool>;
