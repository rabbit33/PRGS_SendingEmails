namespace Holidays
{
    public class RegisterHolidayRequestMessage : HolidayRequestMessage
    {
        public RegisterHolidayRequestMessage(HolidayRequest request)
            : base(request)
        {
        }

        protected override void FillFrom()
        {
            Notification.Sender = HolidayRequest.GetEmployeeEmail();
        }

        protected override void FillTo()
        {
            Notification.Receiver = HolidayRequest.GetManagerEmail();
        }

        protected override void FillSubject()
        {
            Notification.Subject = "I need a holiday!";
        }

        protected override void FillBody()
        {
            Notification.Body = string.Format("Hi {0}, I need a holiday between {1} and {2}!",
                HolidayRequest.GetManagerName(),
                HolidayRequest.GetStartDate(),
                HolidayRequest.GetEndDate());
        }
    }
}
