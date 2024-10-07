using SolidRockIdentity.Emails;
using SolidRockIdentity.Users.DomainEvents;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus;

namespace SolidRockIdentity.Users.DomainHandlers
{
    public class CreateUserSendEmailEventHandler(IEmailSender emailSender) : ILocalEventHandler<CreateUserSendEmailEvent>, ITransientDependency
    {
        public Task HandleEventAsync(CreateUserSendEmailEvent sendEmailEventData)
        {
            return emailSender.SendEmailAsync($"注册成功，给 {sendEmailEventData.User.UserName} 发送邮件[{sendEmailEventData.User.Email}]");
        }
    }
}
