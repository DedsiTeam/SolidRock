using Dedsi.Ddd.CQRS.CommandHandlers;
using SolidRockIdentity.Repositories.Users;
using SolidRockIdentity.Users.Commands;
using Volo.Abp;

namespace SolidRockIdentity.Users.CommandHandlers;

public class UpdateUserCommandHandler(IUserRepository userRepository) : DedsiCommandHandler<UpdateUserCommand, bool>
{
    public override async Task<bool> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
    {
        var user = await userRepository.GetAsync(a => a.Id == command.id);
        if (user == null)
        {
            throw new UserFriendlyException("数据不存在！");
        }
        user.Update(command.UserName,command.Account,command.Email);

        await userRepository.UpdateAsync(user);

        return true;
    }
}
