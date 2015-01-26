namespace Holidays.Interfaces
{
    public interface IEmailServerConfiguration
    {
        string Host { get; }
        int Port { get; }
    }
}
