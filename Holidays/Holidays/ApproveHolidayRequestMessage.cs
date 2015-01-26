using System.Configuration;

namespace Holidays
{
    public class ApproveHolidayRequestMessage : HolidayRequestMessage
    {
        public ApproveHolidayRequestMessage(HolidayRequest request)
            : base(request)
        {
        }

        protected override void FillFrom()
        {
            Notification.Sender = HolidayRequest.GetManagerEmail();
        }

        protected override void FillTo()
        {
            Notification.Receiver = ConfigurationManager.AppSettings["HR_HOLIDAYS"];
        }

        protected override void FillSubject()
        {
            Notification.Subject = "Holiday Request was approved";
        }

        protected override void FillBody()
        {
            Notification.Body = string.Format("The holiday request for the period {1} - {2} for {0} was approved.",
                HolidayRequest.GetEmployeeName(),
                HolidayRequest.GetStartDate(),
                HolidayRequest.GetEndDate());
        }
    }
}