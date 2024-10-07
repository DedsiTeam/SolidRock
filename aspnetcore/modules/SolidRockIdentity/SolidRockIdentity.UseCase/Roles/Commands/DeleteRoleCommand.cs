using Dedsi.Ddd.CQRS.Commands;

namespace SolidRockIdentity.Roles.Commands;

public record DeleteRoleCommand(Guid id) : DedsiCommand<bool>;
