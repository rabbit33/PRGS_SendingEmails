using System.Net.Mail;

namespace Holidays
{
    public class EmailNotifier : INotifier
    {
        private readonly IEmailServerConfiguration emailServerConfiguration;
        private readonly IConverter<Notification, MailMessage> converter;

        public EmailNotifier(IServiceLocator serviceLocator)
        {
            converter = serviceLocator.GetService<IConverter<Notification, MailMessage>>();
            emailServerConfiguration = serviceLocator.GetService<IEmailServerConfiguration>();
        }

        public void Send(Notification message)
        {
            var mailMessage = converter.Convert(message);

            using (var smtpClient = new SmtpClient(emailServerConfiguration.Host, emailServerConfiguration.Port))
            {
                smtpClient.Send(mailMessage);
            }
        }
    }
}