using Dedsi.Ddd.Domain.Queries;
using Dedsi.EntityFrameworkCore.Queries;
using Mapster;
using SolidRockIdentity.EntityFrameworkCore;
using SolidRockIdentity.Repositories.Roles;
using SolidRockIdentity.Roles.Dtos;
using Volo.Abp.EntityFrameworkCore;

namespace SolidRockIdentity.Roles.Queries;

public interface IRoleQuery : IDedsiQuery
{
    /// <summary>
    /// 查询
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<RoleDto> GetAsync(Guid id);
}

public class RoleQuery(
    IDbContextProvider<SolidRockIdentityDbContext> dbContextProvider,
    IRoleRepository roleRepository)
    : DedsiEfCoreQuery<SolidRockIdentityDbContext>(dbContextProvider), IRoleQuery
{
    public async Task<RoleDto> GetAsync(Guid id)
    {
        var entity = await roleRepository.GetAsync(a => a.Id == id);

        return entity.Adapt<RoleDto>();
    }
}