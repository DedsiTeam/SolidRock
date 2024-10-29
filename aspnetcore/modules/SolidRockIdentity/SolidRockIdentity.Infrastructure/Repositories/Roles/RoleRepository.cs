using Dedsi.Ddd.Domain.Repositories;
using Dedsi.EntityFrameworkCore.Repositories;
using SolidRockIdentity.EntityFrameworkCore;
using SolidRockIdentity.Roles;
using Volo.Abp.EntityFrameworkCore;

namespace SolidRockIdentity.Repositories.Roles;

public interface IRoleRepository : IDedsiCqrsRepository<Role, Guid>;

public class RoleRepository(IDbContextProvider<SolidRockIdentityDbContext> dbContextProvider)
: DedsiCqrsEfCoreRepository<SolidRockIdentityDbContext, Role, Guid>(dbContextProvider),
    IRoleRepository;
