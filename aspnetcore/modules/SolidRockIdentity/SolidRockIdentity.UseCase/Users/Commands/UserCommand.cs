using Dedsi.Ddd.CQRS.Commands;
using SolidRockIdentity.Users.Dtos;

namespace SolidRockIdentity.Users.Commands;

public record CreateUserCommand(UserDto user) : DedsiCommand<bool>;

public record UpdateUserCommand(UserDto user) : DedsiCommand<bool>;

public record DeleteUserCommand(Guid id) : DedsiCommand<bool>;