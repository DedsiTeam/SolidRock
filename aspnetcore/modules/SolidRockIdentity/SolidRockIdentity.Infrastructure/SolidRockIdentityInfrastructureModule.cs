using Dedsi.CleanArchitecture.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using SolidRockIdentity.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SolidRockIdentity;

[DependsOn(
    typeof(DedsiCleanArchitectureInfrastructureModule)
)]
public class SolidRockIdentityInfrastructureModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        // EntityFrameworkCore
        context.Services.AddAbpDbContext<SolidRockIdentityDbContext>(options =>
        {
            options.AddDefaultRepositories(true);
        });
    }
}