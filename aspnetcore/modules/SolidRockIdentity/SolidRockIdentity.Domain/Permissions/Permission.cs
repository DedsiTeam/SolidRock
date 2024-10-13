using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace SolidRockIdentity.Permissions;

/// <summary>
/// 权限
/// </summary>
public class Permission : FullAuditedAggregateRoot<Guid>
{
    public Permission()
    {
        
    }

    public Permission(Guid id, string code, string name, string remark) : base(id)
    {
        ChangeCode(code);
        ChangeName(name);
        ChangeRemark(remark);
    }

    /// <summary>
    /// 
    /// </summary>
    public string Code { get; private set; }

    public void ChangeCode(string code)
    {
        Code = Check.NotNullOrWhiteSpace(code, nameof(code));
    }
    
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; private set; }
    
    public void ChangeName(string name)
    {
        Name = Check.NotNullOrWhiteSpace(name, nameof(name));
    }
    
    /// <summary>
    /// 
    /// </summary>
    public string Remark { get; private set; }
    
    public void ChangeRemark(string remark)
    {
        Remark = remark;
    }
}