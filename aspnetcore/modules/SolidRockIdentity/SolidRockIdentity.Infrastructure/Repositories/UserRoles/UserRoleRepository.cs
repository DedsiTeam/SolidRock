using Dedsi.Ddd.Domain.Repositories;
using Dedsi.EntityFrameworkCore.Repositories;
using SolidRockIdentity.EntityFrameworkCore;
using SolidRockIdentity.Users;
using Volo.Abp.EntityFrameworkCore;

namespace SolidRockIdentity.Repositories.UserRoles;

public interface IUserRoleRepository : IDedsiRepository<UserRole, Guid>;

public class UserRoleRepository(IDbContextProvider<SolidRockIdentityDbContext> dbContextProvider)
    : DedsiEfCoreRepository<SolidRockIdentityDbContext, UserRole, Guid>(dbContextProvider),
        IUserRoleRepository;