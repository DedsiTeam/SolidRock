using Dedsi.Ddd.Domain.Queries;
using Dedsi.EntityFrameworkCore.Queries;
using Microsoft.EntityFrameworkCore;
using SolidRockIdentity.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SolidRockIdentity.Users.Queries;

public interface IUserQuery : IDedsiQuery
{
    Task<User?> GetByIdAsync(Guid id);
}

public class UserQuery(IDbContextProvider<SolidRockIdentityDbContext> dbContextProvider)
    : DedsiEfCoreQuery<SolidRockIdentityDbContext>(dbContextProvider),
        IUserQuery
{
    public async Task<User?> GetByIdAsync(Guid id)
    {
        var dbContext = await GetDbContextAsync();
        return await dbContext.Users.Include(b => b.UserRoles).FirstOrDefaultAsync(a => a.Id == id);
    }
}