using System.Net.Mail;
using Holidays.Interfaces;

namespace Holidays
{
    public class EmailNotifier : INotifier
    {
        private readonly IEmailServerConfiguration emailServerConfiguration;

        public EmailNotifier(IServiceLocator serviceLocator)
        {
            emailServerConfiguration = serviceLocator.GetService<IEmailServerConfiguration>();
        }

        public void Send(Notification notification)
        {
            var mailMessage = new MailMessage(notification.Sender, 
                notification.Receiver, 
                notification.Subject,
                notification.Body);

            using (var smtpClient = new SmtpClient(emailServerConfiguration.Host, emailServerConfiguration.Port))
            {
                smtpClient.Send(mailMessage);
            }
        }
    }
}