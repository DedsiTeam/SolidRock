using Dedsi.Ddd.CQRS.Commands;

namespace SolidRockIdentity.Users.Commands;

public record DeleteUserCommand(Guid id) : DedsiCommand<bool>;
