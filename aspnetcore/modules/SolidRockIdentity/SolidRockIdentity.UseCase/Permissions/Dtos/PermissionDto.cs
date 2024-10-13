using Volo.Abp.Application.Dtos;

namespace SolidRockIdentity.Permissions.Dtos;

public class PermissionDto : EntityDto<Guid>
{
    /// <summary>
    /// 
    /// </summary>
    public string Code { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string Remark { get; set; }
}