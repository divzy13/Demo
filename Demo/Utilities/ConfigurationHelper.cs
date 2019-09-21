using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;


namespace Demo.Utilities
{
    public static class ConfigurationHelper
    {
        public static T Get<T>(string name)
        {
            var value = ConfigurationManager.AppSettings[name];
            if (typeof(T).IsEnum)
                return (T)Enum.Parse(typeof(T), value);
            return (T)Convert.ChangeType(value, typeof(T));
        }


    }
}
