using Dedsi.Ddd.Domain.Queries;
using Dedsi.EntityFrameworkCore.Queries;
using Mapster;
using SolidRockIdentity.EntityFrameworkCore;
using SolidRockIdentity.Users.Dtos;
using Volo.Abp.EntityFrameworkCore;

namespace SolidRockIdentity.Users.Queries;

public interface IUserQuery : IDedsiEfCoreQuery
{
    /// <summary>
    /// Id查询
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<UserDto> GetUserAsync(Guid id);
}

public class UserQuery(IDbContextProvider<SolidRockIdentityDbContext> dbContextProvider)
    : DedsiEfCoreQuery<SolidRockIdentityDbContext>(dbContextProvider), IUserQuery
{
    /// <inheritdoc />
    public async Task<UserDto> GetUserAsync(Guid id)
    {
        var user = await GetAsync<User, Guid>(id);
        
        return user.Adapt<UserDto>();
    }
}