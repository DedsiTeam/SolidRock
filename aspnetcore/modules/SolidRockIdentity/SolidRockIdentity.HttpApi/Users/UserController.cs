using Dedsi.Ddd.CQRS.Mediators;
using Microsoft.AspNetCore.Mvc;
using SolidRockIdentity.Users.Commands;
using SolidRockIdentity.Users.Dtos;
using SolidRockIdentity.Users.Queries;

namespace SolidRockIdentity.Users;

/// <summary>
/// 用户
/// </summary>
/// <param name="dedsiMediator"></param>
/// <param name="userQuery"></param>
public class UserController(IDedsiMediator dedsiMediator, IUserQuery userQuery) : SolidRockIdentityController
{
    /// <summary>
    /// 创建用户
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    [HttpPost]
    public Task<Guid> CreateAsync(CreateUserInputDto input)
    {
        return dedsiMediator.PublishAsync(new CreateUserCommand(input.UserName, input.Account, input.Email));
    }

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    public Task<bool> UpdateAsync(UpdateUserInputDto input)
    {
        return dedsiMediator.PublishAsync(new UpdateUserCommand(input.Id, input.UserName, input.Account, input.Email));
    }

    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpPost("{id}")]
    public Task<bool> DeleteAsync(Guid id)
    {
        return dedsiMediator.PublishAsync(new DeleteUserCommand(id));
    }

    /// <summary>
    /// 查询
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public Task<User?> GetAsync(Guid id)
    {
        return userQuery.GetByIdAsync(id);
    }

    /// <summary>
    /// 设置用户角色
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<bool> SetUserRoleAsync(SetUserRoleCommand command)
    {
        await dedsiMediator.PublishAsync(command);
        return true;
    }
}