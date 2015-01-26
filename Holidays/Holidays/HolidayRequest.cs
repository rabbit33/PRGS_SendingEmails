namespace Holidays
{
    public class HolidayRequest
    {
        public Employee Employee { get; set; }
        public Interval Interval { get; set; }

        public string GetEmployeeEmail()
        {
            return Employee.Email;
        }

        public string GetEmployeeName()
        {
            return Employee.Name;
        }

        public string GetManagerEmail()
        {
            return Employee.Manager.Email;
        }

        public string GetManagerName()
        {
            return Employee.Manager.Name;
        }

        public string GetStartDate()
        {
            return Interval.StartDate.ToString("MM-dd-yyyy");
        }

        public string GetEndDate()
        {
            return Interval.EndDate.ToString("MM-dd-yyyy");
        }
    }
}