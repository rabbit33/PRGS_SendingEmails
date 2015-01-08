using System.Net.Mail;

namespace Holidays
{
    public interface IEmailServer
    {
        void Send(MailMessage mailMessage);
    }
}