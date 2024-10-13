namespace SolidRockIdentity.Users;

public class UserRole
{
    public UserRole(){ }
    public UserRole(Guid userId, Guid roleId, string roleName)
    {
        UserId = userId;
        RoleId = roleId;
        RoleName = roleName;
    }

    public Guid UserId { get; private set; }

    public Guid RoleId { get; private set; }

    public string RoleName { get; private set; }
}
