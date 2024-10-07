using Dedsi.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace SolidRockIdentity;

[DependsOn(
    typeof(SolidRockIdentityUseCaseModule),
    typeof(DedsiAspNetCoreModule)
)]
public class SolidRockIdentityHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(SolidRockIdentityHttpApiModule).Assembly);
        });
    }

}