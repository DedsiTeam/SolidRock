using Volo.Abp.Domain.Entities.Auditing;

namespace SolidRockIdentity.Roles;

/// <summary>
/// 角色
/// </summary>
public class Role : FullAuditedAggregateRoot<Guid>
{
    public Role() { }

    /// <summary>
    /// 
    /// </summary>
    public string RoleName { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string Remark { get; private set; }
    
    /// <summary>
    /// 角色 的 权限
    /// </summary>
    public ICollection<RolePermission> RolePermissions { get; private set; } = new List<RolePermission>();
}
