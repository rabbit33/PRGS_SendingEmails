using System;
using System.Collections.Generic;
using Holidays.Interfaces;

namespace Holidays
{
    public class ServiceLocator : IServiceLocator
    {
        private readonly IDictionary<object, object> services;

        internal ServiceLocator()
        {
            services = new Dictionary<object, object>
            {
                {typeof (IEmailServerConfiguration), new DefaultEmailServerConfiguration()}
            };
        }

        public T GetService<T>()
        {
            try
            {
                return (T) services[typeof (T)];
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException("The requested service is not registered");
            }
        }
    }
}