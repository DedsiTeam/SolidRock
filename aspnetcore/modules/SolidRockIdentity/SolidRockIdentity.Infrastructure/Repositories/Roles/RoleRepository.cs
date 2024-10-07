using Dedsi.Ddd.Domain.Repositories;
using Dedsi.EntityFrameworkCore.Repositories;
using SolidRockIdentity.EntityFrameworkCore;
using SolidRockIdentity.Roles;
using Volo.Abp.EntityFrameworkCore;

namespace SolidRockIdentity.Repositories.Roles;

public interface IRoleRepository : IDedsiRepository<Role, Guid>;

public class RoleRepository(IDbContextProvider<SolidRockIdentityDbContext> dbContextProvider)
: DedsiEfCoreRepository<SolidRockIdentityDbContext, Role, Guid>(dbContextProvider),
    IRoleRepository;
