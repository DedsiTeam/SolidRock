namespace SolidRockIdentity.Users;

public class UserRole
{
    public Guid UserId { get; set; }

    public Guid RoleId { get; set; }

    public string RoleName { get; set; }
}
