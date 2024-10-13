using Dedsi.Ddd.Domain.Queries;
using Dedsi.EntityFrameworkCore.Queries;
using Mapster;
using Microsoft.EntityFrameworkCore;
using SolidRockIdentity.EntityFrameworkCore;
using SolidRockIdentity.Permissions.Dtos;
using Volo.Abp.EntityFrameworkCore;

namespace SolidRockIdentity.Permissions.Queries;

public interface IPermissionQuery : IDedsiQuery
{
    Task<PermissionDto> GetAsync(Guid id);
}

public class PermissionQuery(IDbContextProvider<SolidRockIdentityDbContext> dbContextProvider) 
    : DedsiEfCoreQuery<SolidRockIdentityDbContext>(dbContextProvider), 
        IPermissionQuery
{
    public async Task<PermissionDto> GetAsync(Guid id)
    {
        var dbContext = await GetDbContextAsync();
        var entity = await dbContext.Permissions.FirstOrDefaultAsync(p => p.Id == id);

        return entity.Adapt<PermissionDto>();
    }
}