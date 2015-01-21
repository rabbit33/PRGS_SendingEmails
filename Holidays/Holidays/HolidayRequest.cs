using System;

namespace Holidays
{
    public class HolidayRequest
    {
        public Employee Employee { get; set; }

        //holiday period
        public DateTime From;
        public DateTime To;

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
    }
}