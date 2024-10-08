namespace SolidRockIdentity.Roles;

public class RolePermission
{
    public Guid RoleId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid PermissionId { get; private set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string PermissionName { get; private set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string Remark { get; private set; }
}