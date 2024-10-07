using Microsoft.Extensions.Logging;

namespace SolidRockIdentity.Emails;

public class TestEmailSender(ILogger<TestEmailSender> logger) : IEmailSender
{
    public Task SendEmailAsync(string content)
    {
        logger.LogInformation("发送邮件：" + content);
        return Task.CompletedTask;
    }
}