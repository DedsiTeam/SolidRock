namespace SolidRockIdentity.Roles.Dtos;

public class RolePermissionDto
{
    public Guid RoleId { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public string PermissionCode { get; private set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string PermissionName { get; private set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string Remark { get; private set; }
}