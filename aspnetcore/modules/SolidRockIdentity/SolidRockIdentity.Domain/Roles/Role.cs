using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace SolidRockIdentity.Roles;

/// <summary>
/// 角色
/// </summary>
public class Role : FullAuditedAggregateRoot<Guid>
{
    public Role(Guid id,string name, string remark): base(id)
    {
        ChangeName(name);
        ChangeRemark(remark);
    }

    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

    public void ChangeName(string name)
    {
        Name = Check.NotNullOrWhiteSpace(name, nameof(name));
    }
    
    /// <summary>
    /// 
    /// </summary>
    public string Remark { get; private set; }

    public void ChangeRemark(string remark)
    {
        Remark = remark;
    }
    
    /// <summary>
    /// 角色 的 权限
    /// </summary>
    public ICollection<RolePermission> RolePermissions { get; private set; } = new List<RolePermission>();

    public void AddRolePermission(RolePermission rolePermission)
    {
        if (RolePermissions.Any(a => a.PermissionCode == rolePermission.PermissionCode) == false)
        {
            RolePermissions.Add(rolePermission);
        }
    }

    public void RemoveRolePermission(RolePermission rolePermission)
    {
        RolePermissions.Remove(rolePermission);
    }

    public void ClearRolePermissions()
    {
        RolePermissions.Clear();
    }
}
