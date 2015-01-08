namespace Holidays
{
    public class HolidayRequestHandler : IHolidayRequestHandler
    {
        private readonly IEmailServer emailServer;
        private readonly HolidayRequestMailMessage holidayRequestMailMessage;

        public HolidayRequestHandler(IEmailServer emailServer, HolidayRequestMailMessage holidayRequestMailMessage)
        {
            this.emailServer = emailServer;
            this.holidayRequestMailMessage = holidayRequestMailMessage;
        }

        public void HandleHolidayRequest(HolidayRequest holidayRequest)
        {
            holidayRequestMailMessage.Compose();
            emailServer.Send(holidayRequestMailMessage.MailMessage);
        }
    }
}