using System.Net.Mail;

namespace Holidays
{
    public class MyEmailServer : IEmailServer
    {
        private readonly IEmailServerConfiguration emailServerConfiguration;
        
        public MyEmailServer(IEmailServerConfiguration emailServerConfiguration)
        {
            this.emailServerConfiguration = emailServerConfiguration;
        }

        public void Send(MailMessage mailMessage)
        {
            using (var smtpClient = new SmtpClient(emailServerConfiguration.Host, emailServerConfiguration.Port))
            {
                smtpClient.Send(mailMessage);
            }
        }
    }
}