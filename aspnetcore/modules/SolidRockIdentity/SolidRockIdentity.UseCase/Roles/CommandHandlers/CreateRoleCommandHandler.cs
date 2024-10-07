using Dedsi.Ddd.CQRS.CommandHandlers;
using SolidRockIdentity.Repositories.Roles;
using SolidRockIdentity.Roles.Commands;
using Volo.Abp.Guids;

namespace SolidRockIdentity.Roles.CommandHandlers;

public class CreateRoleCommandHandler(IRoleRepository roleRepository, IGuidGenerator guidGenerator) : DedsiCommandHandler<CreateRoleCommand, Guid>
{
    public async override Task<Guid> Handle(CreateRoleCommand command, CancellationToken cancellationToken)
    {
        var role = new Role(guidGenerator.Create(), command.RoleCode, command.RoleName);

        await roleRepository.InsertAsync(role);

        return role.Id;
    }
}
