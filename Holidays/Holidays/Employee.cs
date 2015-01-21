namespace Holidays
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Employee Manager { get; set; }
    }
}