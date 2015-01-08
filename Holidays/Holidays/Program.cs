using System;

namespace Holidays
{
    class Program
    {
        static void Main()
        {
            var request = new HolidayRequest
            {
                EmployeeEmail = "alexandra.popescu@iquestgroup.com",
                EmployeeName = "Alexandra Popescu",
                From = DateTime.Now,
                To = DateTime.Now.AddDays(4),
                ManagerEmail = "alexandra.popescu@iquestgroup.com"
            };

            var emailServerConfig = new DefaultEmailServerConfiguration();
            var emailServer = new MyEmailServer(emailServerConfig);

            var holidayRequestHandler = new HolidayRequestHandler(emailServer, new RegisterHolidayRequestMessage(request));
            holidayRequestHandler.HandleHolidayRequest(request);

            holidayRequestHandler = new HolidayRequestHandler(emailServer, new ApproveHolidayRequestMessage(request));
            holidayRequestHandler.HandleHolidayRequest(request);

            holidayRequestHandler = new HolidayRequestHandler(emailServer, new RejectHolidayRequestMessage(request));
            holidayRequestHandler.HandleHolidayRequest(request);
        }
    }
}
