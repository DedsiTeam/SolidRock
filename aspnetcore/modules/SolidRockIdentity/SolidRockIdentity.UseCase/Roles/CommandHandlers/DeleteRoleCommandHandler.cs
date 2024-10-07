using Dedsi.Ddd.CQRS.CommandHandlers;
using SolidRockIdentity.Repositories.Roles;
using SolidRockIdentity.Roles.Commands;

namespace SolidRockIdentity.Roles.CommandHandlers;

public class DeleteRoleCommandHandler(IRoleRepository roleRepository) : DedsiCommandHandler<DeleteRoleCommand, bool>
{
    public override async Task<bool> Handle(DeleteRoleCommand command, CancellationToken cancellationToken)
    {
        await roleRepository.DeleteAsync(a => a.Id == command.id);
        return true;
    }
}
