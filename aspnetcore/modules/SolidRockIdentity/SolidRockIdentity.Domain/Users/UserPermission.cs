﻿namespace SolidRockIdentity.Users;

public class UserPermission
{
    /// <summary>
    /// 
    /// </summary>
    public Guid UserId { get; private set; }
    
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