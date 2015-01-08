using System.Net.Mail;

namespace Holidays
{
    public class RegisterHolidayRequestMessage : HolidayRequestMailMessage
    {
        public RegisterHolidayRequestMessage(HolidayRequest request)
            : base(request)
        {
        }

        protected override void FillFrom()
        {
            MailMessage.From = new MailAddress(HolidayRequest.EmployeeEmail);
        }

        protected override void FillTo()
        {
            MailMessage.To.Add(new MailAddress(HolidayRequest.ManagerEmail));
        }

        protected override void FillSubject()
        {
            MailMessage.Subject = "I need a holiday!";
        }

        protected override void FillBody()
        {
            MailMessage.Body = string.Format("Dear Bo$$, I need a holiday between {0} and {1}!",
                HolidayRequest.From.ToString("MM-dd-yyyy"),
                HolidayRequest.To.ToString("MM-dd-yyyy"));
        }
    }
}
