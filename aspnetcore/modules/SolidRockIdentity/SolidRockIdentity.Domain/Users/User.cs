using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace SolidRockIdentity.Users;

/// <summary>
/// 用户
/// </summary>
public class User : FullAuditedAggregateRoot<Guid>
{
    public User()
    {
        
    }
    
    public User(Guid id,string name, string account, string passWord, string phone, string email, string remark) : base(id)
    {
        ChangeName(name);
        ChangeAccount(account);
        ChangePassWord(passWord);
        ChangePhone(phone);
        ChangeEmail(email);
        ChangeRemark(remark);
    }

    public string Name { get; private set; }

    public void ChangeName(string name)
    {
        Name = Check.NotNullOrWhiteSpace(name, nameof(name));
    }

    public string Account { get; private set; }
    
    public void ChangeAccount(string account)
    {
        Account = Check.NotNullOrWhiteSpace(account, nameof(account));
    }

    public string PassWord { get; private set; }

    public void ChangePassWord(string passWord)
    {
        PassWord = Check.NotNullOrWhiteSpace(passWord, nameof(passWord));
    }

    public string Phone { get; private set; }

    public void ChangePhone(string phone)
    {
        Phone = Check.NotNullOrWhiteSpace(phone, nameof(phone));
    }
    
    public string Email { get; private set; }

    public void ChangeEmail(string email)
    {
        Email = Check.NotNullOrWhiteSpace(email, nameof(email));
    }
    
    /// <summary>
    /// 
    /// </summary>
    public string Remark { get; private set; }
    
    public void ChangeRemark(string remark)
    {
        Remark = remark;
    }
    
    
    /// <summary>
    /// 用户 的 角色
    /// </summary>
    public ICollection<UserRole> UserRoles { get; private set; } = new List<UserRole>();

    public void AddUserRole(UserRole role)
    {
        // 不存在：添加
        if (UserRoles.Any(a => a.RoleId == role.RoleId) == false)
        {
            UserRoles.Add(role);
        }
    }

    public void RemoveUserRole(UserRole role)
    {
        UserRoles.Remove(role);
    }

    public void ClearUserRoles()
    {
        UserRoles.Clear();
    }
    
    /// <summary>
    /// 用户 的 权限
    /// </summary>
    public ICollection<UserPermission> UserPermissions { get; private set; } = new List<UserPermission>();

    public void AddUserPermission(UserPermission permission)
    {
        // 不存在：添加
        if (UserPermissions.Any(a => a.UserId == permission.UserId) == false)
        {
            UserPermissions.Add(permission);
        }
    }

    public void RemoveUserPermission(UserPermission permission)
    {
        UserPermissions.Remove(permission);
    }

    public void ClearUserPermissions()
    {
        UserPermissions.Clear();
    }
    
}