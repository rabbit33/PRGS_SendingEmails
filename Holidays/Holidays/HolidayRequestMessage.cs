namespace Holidays
{
    public abstract class HolidayRequestMessage
    {
        private readonly HolidayRequest holidayRequest;

        protected HolidayRequestMessage(HolidayRequest holidayRequest)
        {
            this.holidayRequest = holidayRequest;
        }

        public HolidayRequest HolidayRequest { get { return holidayRequest; } }

        public abstract void Compose();
    }
}
