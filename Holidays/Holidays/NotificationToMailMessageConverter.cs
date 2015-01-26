using System.Net.Mail;
using Holidays.Interfaces;

namespace Holidays
{
    public class NotificationToMailMessageConverter : IConverter<Notification, MailMessage>
    {
        public MailMessage Convert(Notification notification)
        {
            return new MailMessage(notification.Sender, notification.Receiver, notification.Subject, notification.Body);
        }
    }
}