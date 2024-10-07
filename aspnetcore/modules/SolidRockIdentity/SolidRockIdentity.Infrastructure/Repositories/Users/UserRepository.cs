using Dedsi.Ddd.Domain.Repositories;
using Dedsi.EntityFrameworkCore.Repositories;
using SolidRockIdentity.EntityFrameworkCore;
using SolidRockIdentity.Users;
using Volo.Abp.EntityFrameworkCore;

namespace SolidRockIdentity.Repositories.Users;

public interface IUserRepository : IDedsiRepository<User, Guid>;

public class UserRepository(IDbContextProvider<SolidRockIdentityDbContext> dbContextProvider)
    : DedsiEfCoreRepository<SolidRockIdentityDbContext, User, Guid>(dbContextProvider),
        IUserRepository;