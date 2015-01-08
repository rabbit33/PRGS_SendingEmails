using System.Net.Mail;

namespace Holidays
{
    public class RejectHolidayRequestMessage : HolidayRequestMailMessage
    {
        public RejectHolidayRequestMessage(HolidayRequest holidayRequest)
            : base(holidayRequest)
        {
        }

        protected override void FillFrom()
        {
            MailMessage.From = new MailAddress(HolidayRequest.ManagerEmail);
        }

        protected override void FillTo()
        {
            MailMessage.To.Add(new MailAddress(HolidayRequest.EmployeeEmail));
        }

        protected override void FillSubject()
        {
            MailMessage.Subject = "Holiday Request was rejected";
        }

        protected override void FillBody()
        {
            MailMessage.Body = string.Format(@"Dear {0}, your holiday request for the period {1} - {2} was rejected. I'm sorry! :(",
                HolidayRequest.EmployeeName,
                HolidayRequest.From.ToString("MM-dd-yyyy"),
                HolidayRequest.To.ToString("MM-dd-yyyy"));
        }
    }
}