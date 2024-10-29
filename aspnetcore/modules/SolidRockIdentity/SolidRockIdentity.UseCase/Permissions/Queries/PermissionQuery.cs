using Dedsi.Ddd.Domain.Queries;
using Dedsi.EntityFrameworkCore.Queries;
using Mapster;
using SolidRockIdentity.EntityFrameworkCore;
using SolidRockIdentity.Permissions.Dtos;
using Volo.Abp.EntityFrameworkCore;

namespace SolidRockIdentity.Permissions.Queries;

public interface IPermissionQuery : IDedsiEfCoreQuery
{
    Task<PermissionDto> GetAsync(Guid id);
}

public class PermissionQuery(IDbContextProvider<SolidRockIdentityDbContext> dbContextProvider) 
    : DedsiEfCoreQuery<SolidRockIdentityDbContext>(dbContextProvider), 
        IPermissionQuery
{
    public async Task<PermissionDto> GetAsync(Guid id)
    {
        var entity = await GetAsync<Permission,Guid>(id);

        return entity.Adapt<PermissionDto>();
    }
}