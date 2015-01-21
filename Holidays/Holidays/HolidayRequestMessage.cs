namespace Holidays
{
    public abstract class HolidayRequestMessage
    {
        private readonly HolidayRequest request;

        protected HolidayRequestMessage(HolidayRequest request)
        {
            this.request = request;
        }

        public HolidayRequest HolidayRequest { get { return request; } }
        public Notification Notification { get; private set; }

        public void Compose()
        {
            Notification = new Notification();
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
