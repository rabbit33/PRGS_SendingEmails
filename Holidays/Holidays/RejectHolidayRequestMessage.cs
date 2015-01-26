namespace Holidays
{
    public class RejectHolidayRequestMessage : HolidayRequestMessage
    {
        public RejectHolidayRequestMessage(HolidayRequest request)
            : base(request)
        {
        }

        protected override void FillFrom()
        {
            Notification.Sender = HolidayRequest.GetManagerEmail();
        }

        protected override void FillTo()
        {
            Notification.Receiver = HolidayRequest.GetEmployeeEmail();
        }

        protected override void FillSubject()
        {
            Notification.Subject = "Holiday Request was rejected";
        }

        protected override void FillBody()
        {
            Notification.Body = string.Format(@"Hi {0}, your holiday request for the period {1} - {2} was rejected. I'm sorry! :(",
                HolidayRequest.GetEmployeeName(),
                HolidayRequest.Interval.StartDate.ToString("MM-dd-yyyy"),
                HolidayRequest.Interval.EndDate.ToString("MM-dd-yyyy"));
        }
    }
}