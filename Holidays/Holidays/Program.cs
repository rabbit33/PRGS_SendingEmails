using System;

namespace Holidays
{
    class Program
    {
        static void Main()
        {
            var request = new HolidayRequest
            {
                Employee = new Employee
                {
                    Name = "Alexandra",
                    Email = "alexandra.popescu@iquestgroup.com",
                    Manager = new Employee
                    {
                        Name = "John Doe",
                        Email = "alexandra.popescu@iquestgroup.com"
                    }
                },
                Interval = new Interval
                {
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(4)
                }
            };

            var serviceLocator = new ServiceLocator();

            var emailNotifier = new EmailNotifier(serviceLocator);

            var processor = new HolidayRequestProcessor(emailNotifier, new RegisterHolidayRequestMessage(request));
            processor.HandleHolidayRequest();

            processor = new HolidayRequestProcessor(emailNotifier, new ApproveHolidayRequestMessage(request));
            processor.HandleHolidayRequest();

            processor = new HolidayRequestProcessor(emailNotifier, new RejectHolidayRequestMessage(request));
            processor.HandleHolidayRequest();
        }
    }
}
