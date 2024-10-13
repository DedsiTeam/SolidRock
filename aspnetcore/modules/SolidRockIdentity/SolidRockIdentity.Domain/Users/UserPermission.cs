using Volo.Abp;

namespace SolidRockIdentity.Users;

public class UserPermission
{
    public UserPermission()
    {
        
    }
    public UserPermission(Guid userId, string permissionCode, string permissionName, string remark)
    {
        UserId = userId;
        Remark = remark;
        ChangePermissionCode(permissionCode);
        ChangePermissionName(permissionName);
    }

    /// <summary>
    /// 
    /// </summary>
    public Guid UserId { get; private set; }
    
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