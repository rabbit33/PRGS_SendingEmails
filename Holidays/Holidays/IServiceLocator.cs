namespace Holidays
{
    public interface IServiceLocator
    {
        T GetService<T>();
    }
}