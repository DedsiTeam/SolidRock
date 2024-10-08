using Volo.Abp.Domain.Entities.Auditing;

namespace SolidRockIdentity.Users;

/// <summary>
/// 用户
/// </summary>
public class User : FullAuditedAggregateRoot<Guid>
{
    public User() { }

    public string Name { get; private set; }

    public string Account { get; private set; }

    public string PassWord { get; private set; }

    public string Phone { get; private set; }
    
    public string Email { get; private set; }

    /// <summary>
    /// 用户 的 角色
    /// </summary>
    public ICollection<UserRole> UserRoles { get; private set; } = new List<UserRole>();
    
    /// <summary>
    /// 用户 的 权限
    /// </summary>
    public ICollection<UserPermission> UserPermissions { get; private set; } = new List<UserPermission>();

}