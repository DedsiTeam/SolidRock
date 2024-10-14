using Dedsi.Ddd.Domain.Queries;
using Dedsi.EntityFrameworkCore.Queries;
using Mapster;
using Microsoft.EntityFrameworkCore;
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
    
    /// <summary>
    /// 获得所有的角色以及角色对应的权限
    /// </summary>
    /// <returns></returns>
    Task<List<RoleDto>> GetAllAsync();
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

    public async Task<List<RoleDto>> GetAllAsync()
    {
        var dbContext = await GetDbContextAsync();

        var dbList = await dbContext.Roles
                                .Include(a => a.RolePermissions)
                                .OrderBy(a => a.Name)
                                .ToListAsync();
        
        return dbList.Adapt<List<RoleDto>>();
    }
}