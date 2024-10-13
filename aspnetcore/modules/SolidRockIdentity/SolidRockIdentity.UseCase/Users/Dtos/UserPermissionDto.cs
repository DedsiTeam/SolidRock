namespace SolidRockIdentity.Users.Dtos;

public class UserPermissionDto
{
    public Guid UserId { get; set; }

    public string PermissionCode { get; set; }

    public string PermissionName { get; set; }

    public string Remark { get; set; }
}