using Volo.Abp.Domain.Entities.Auditing;

namespace SolidRockIdentity.Permissions;

/// <summary>
/// 权限
/// </summary>
public class Permission : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; private set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string Remark { get; private set; }
}