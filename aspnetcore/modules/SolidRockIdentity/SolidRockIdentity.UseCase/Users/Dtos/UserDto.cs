using Volo.Abp.Application.Dtos;

namespace SolidRockIdentity.Users.Dtos;

public class UserDto : EntityDto<Guid?>
{
    public string Name { get; set; }
    
    public string Account { get; set; }
    
    public string PassWord { get; set; }
    
    public string Phone { get; set; }
    
    public string Email { get; set; }

    public string Remark { get; set; }
    
    /// <summary>
    /// 用户 的 角色
    /// </summary>
    public List<UserRoleDto> UserRoles { get; set; }
    
    /// <summary>
    /// 用户 的 权限
    /// </summary>
    public List<UserPermissionDto> UserPermissions { get; set; }

}