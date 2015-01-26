namespace Holidays.Interfaces
{
    public interface IServiceLocator
    {
        T GetService<T>();
    }
}