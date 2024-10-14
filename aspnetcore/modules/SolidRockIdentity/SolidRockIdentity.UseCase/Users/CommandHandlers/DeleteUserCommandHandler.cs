using Dedsi.Ddd.CQRS.CommandHandlers;
using SolidRockIdentity.Repositories.Users;
using SolidRockIdentity.Users.Commands;

namespace SolidRockIdentity.Users.CommandHandlers;

public class DeleteUserCommandHandler(IUserRepository userRepository): DedsiCommandHandler<DeleteUserCommand, bool>
{
    public override async Task<bool> Handle(DeleteUserCommand command, CancellationToken cancellationToken)
    {
        await userRepository.DeleteAsync(a => a.Id == command.id, false, cancellationToken);
        
        return true;
    }
}