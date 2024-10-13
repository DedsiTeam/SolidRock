using Dedsi.Ddd.CQRS.Commands;
using SolidRockIdentity.Permissions.Dtos;

namespace SolidRockIdentity.Permissions.Commands;

public record CreatePermissionCommand(PermissionDto permission) : DedsiCommand<bool>;

public record UpdatePermissionCommand(Guid id,PermissionDto permission) : DedsiCommand<bool>;

public record DeletePermissionCommand(Guid id) : DedsiCommand<bool>;


    