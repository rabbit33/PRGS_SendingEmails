namespace Holidays
{
    public interface IEmailServerConfiguration
    {
        string Host { get; }
        int Port { get; }
    }
}
