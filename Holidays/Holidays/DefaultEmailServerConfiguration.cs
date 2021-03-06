﻿using System.Configuration;
using Holidays.Interfaces;

namespace Holidays
{
    public class DefaultEmailServerConfiguration : IEmailServerConfiguration
    {
        public string Host
        {
            get { return ConfigurationManager.AppSettings["EmailServer"]; }
        }

        public int Port
        {
            get { return int.Parse(ConfigurationManager.AppSettings["EmailPort"]); }
        }
    }
}