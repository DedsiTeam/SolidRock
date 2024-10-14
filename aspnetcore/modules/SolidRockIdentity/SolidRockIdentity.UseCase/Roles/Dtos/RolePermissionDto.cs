namespace SolidRockIdentity.Roles.Dtos;

public class RolePermissionDto
{
    public Guid RoleId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string PermissionCode { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string PermissionName { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string Remark { get; set; }
}