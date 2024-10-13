using Volo.Abp;

namespace SolidRockIdentity.Roles;

public class RolePermission
{
    public RolePermission()
    {
        
    }
    
    public RolePermission(Guid roleId, string permissionCode, string permissionName, string remark)
    {
        RoleId = roleId;
        Remark = remark;
        ChangePermissionCode(permissionCode);
        ChangePermissionName(permissionName);
    }

    public Guid RoleId { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public string PermissionCode { get; private set; }

    public void ChangePermissionCode(string newPermissionCode)
    {
        PermissionCode = Check.NotNullOrWhiteSpace(newPermissionCode, nameof(newPermissionCode));
    }
    
    /// <summary>
    /// 
    /// </summary>
    public string PermissionName { get; private set; }

    public void ChangePermissionName(string newPermissionName)
    {
        PermissionName = Check.NotNullOrWhiteSpace(newPermissionName, nameof(newPermissionName));
    }
    
    /// <summary>
    /// 
    /// </summary>
    public string Remark { get; private set; }
}