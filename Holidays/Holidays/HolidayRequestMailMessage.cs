using System.Net.Mail;

namespace Holidays
{
    public abstract class HolidayRequestMailMessage : HolidayRequestMessage
    {
        protected HolidayRequestMailMessage(HolidayRequest holidayRequest) : base(holidayRequest)
        {
        }

        public MailMessage MailMessage { get; private set; }

        public override void Compose()
        {
            MailMessage = new MailMessage();
            FillFrom();
            FillTo();
            FillSubject();
            FillBody();
        }

        protected abstract void FillFrom();
        protected abstract void FillTo();
        protected abstract void FillSubject();
        protected abstract void FillBody();
    }
}