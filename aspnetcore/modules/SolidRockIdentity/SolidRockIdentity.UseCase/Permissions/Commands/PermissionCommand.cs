using Dedsi.Ddd.CQRS.Commands;
using SolidRockIdentity.Permissions.Dtos;

namespace SolidRockIdentity.Permissions.Commands;

public record CreatePermissionCommand(CreateUpdatePermissionDto CreateUpdatePermissionDto) : DedsiCommand<bool>;

public record UpdatePermissionCommand(Guid id,CreateUpdatePermissionDto CreateUpdatePermissionDto) : DedsiCommand<bool>;

public record DeletePermissionCommand(Guid id) : DedsiCommand<bool>;


    