using Dedsi.Ddd.CQRS.Mediators;
using Microsoft.AspNetCore.Mvc;
using SolidRockIdentity.Permissions.Commands;
using SolidRockIdentity.Permissions.Dtos;
using SolidRockIdentity.Permissions.Queries;

namespace SolidRockIdentity.Permissions;

/// <summary>
/// 权限
/// </summary>
/// <param name="mediator"></param>
/// <param name="permissionQuery"></param>
public class PermissionController(
    IDedsiMediator mediator,
    IPermissionQuery permissionQuery) 
    : SolidRockIdentityController
{
    /// <summary>
    /// 添加
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    public Task<bool> CreateAsync(PermissionDto input)
    {
        var command = new CreatePermissionCommand(input);
        return mediator.PublishAsync(command);
    }
    
    /// <summary>
    /// 添加
    /// </summary>
    /// <param name="id"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    public Task<bool> UpdateAsync(Guid id,PermissionDto input)
    {
        var command = new UpdatePermissionCommand(id, input);
        return mediator.PublishAsync(command);
    }

    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpPost]
    public Task<bool> DeleteAsync(Guid id)
    {
        var command = new DeletePermissionCommand(id);
        return mediator.PublishAsync(command);
    }

    /// <summary>
    /// 查询
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public Task<PermissionDto> GetAsync(Guid id)
    {
        return permissionQuery.GetAsync(id);
    }
}