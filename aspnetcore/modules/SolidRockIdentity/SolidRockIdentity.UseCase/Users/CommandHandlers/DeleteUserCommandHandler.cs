using Dedsi.Ddd.CQRS.CommandHandlers;
using SolidRockIdentity.Repositories.Users;
using SolidRockIdentity.Users.Commands;
using SolidRockIdentity.Users.Queries;

namespace SolidRockIdentity.Users.CommandHandlers;

public class DeleteUserCommandHandler(IUserRepository userRepository, IUserQuery userQuery) : DedsiCommandHandler<DeleteUserCommand, bool>
{
    public override async Task<bool> Handle(DeleteUserCommand command, CancellationToken cancellationToken)
    {
        var user = await userQuery.GetByIdAsync(command.id);
        await userRepository.DeleteAsync(user);
        return true;
    }
}
