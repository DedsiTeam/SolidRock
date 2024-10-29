using Dedsi.Ddd.Domain.Repositories;
using Dedsi.EntityFrameworkCore.Repositories;
using SolidRockIdentity.EntityFrameworkCore;
using SolidRockIdentity.Permissions;
using Volo.Abp.EntityFrameworkCore;

namespace SolidRockIdentity.Repositories.Permissions;

public interface IPermissionRepository : IDedsiCqrsRepository<Permission, Guid>;

public class PermissionRepository(IDbContextProvider<SolidRockIdentityDbContext> dbContextProvider)
    : DedsiCqrsEfCoreRepository<SolidRockIdentityDbContext, Permission, Guid>(dbContextProvider),
        IPermissionRepository;