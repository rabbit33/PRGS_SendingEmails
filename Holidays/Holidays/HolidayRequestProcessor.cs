namespace Holidays
{
    public class HolidayRequestProcessor : IHolidayRequestProcessor
    {
        private readonly INotifier notifier;
        private readonly HolidayRequestMessage holidayRequestMessage;

        public HolidayRequestProcessor(INotifier notifier, HolidayRequestMessage holidayRequestMessage)
        {
            this.notifier = notifier;
            this.holidayRequestMessage= holidayRequestMessage;
        }

        public void HandleHolidayRequest()
        {
            holidayRequestMessage.Compose();

            notifier.Send(holidayRequestMessage.Notification);
        }
    }
}