using System.Reflection;
using Dedsi.Ddd.CQRS;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace SolidRockIdentity;

[DependsOn(
    // SolidRockIdentity
    typeof(SolidRockIdentityDomainModule),
    typeof(SolidRockIdentityInfrastructureModule),
    
    typeof(DedsiDddCQRSModule)
)]
public class SolidRockIdentityUseCaseModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        // MediatR
        context.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
    }
}