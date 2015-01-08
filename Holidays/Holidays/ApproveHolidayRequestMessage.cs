using System.Net.Mail;

namespace Holidays
{
    public class ApproveHolidayRequestMessage : HolidayRequestMailMessage
    {
        public ApproveHolidayRequestMessage(HolidayRequest holidayRequest)
            : base(holidayRequest)
        {
        }

        protected override void FillFrom()
        {
            MailMessage.From = new MailAddress(HolidayRequest.ManagerEmail);
        }

        protected override void FillTo()
        {
            //hr_holidays address
            MailMessage.To.Add(new MailAddress("alexandra.popescu@iquestgroup.com"));
        }

        protected override void FillSubject()
        {
            MailMessage.Subject = "Holiday Request was approved";
        }

        protected override void FillBody()
        {
            MailMessage.Body = string.Format("Dear holidays department, the holiday request for the period {1} - {2} for {0} was approved.",
                HolidayRequest.EmployeeName,
                HolidayRequest.From.ToString("MM-dd-yyyy"),
                HolidayRequest.To.ToString("MM-dd-yyyy"));
        }
    }
}