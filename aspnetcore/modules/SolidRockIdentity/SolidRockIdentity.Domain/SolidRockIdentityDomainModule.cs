using Dedsi.CleanArchitecture.Domain;
using Volo.Abp.Modularity;

namespace SolidRockIdentity;

[DependsOn(
    typeof(DedsiCleanArchitectureDomainModule)    
)]
public class SolidRockIdentityDomainModule : AbpModule
{
    
}