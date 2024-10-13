using Volo.Abp.Application.Dtos;

namespace SolidRockIdentity.Roles.Dtos;

public class RoleDto : EntityDto<Guid>
{
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string Remark { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public List<RolePermissionDto> RolePermissions { get; set; }
}