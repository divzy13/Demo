using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;
using System.Reflection;

namespace Demo.Utilities
{
    public static class ConfigurationHelper
    {
        public static T Get<T>(string name)
        {
            ExeConfigurationFileMap map = new ExeConfigurationFileMap();
            map.ExeConfigFilename = Assembly.GetExecutingAssembly().Location + ".config";
            Configuration libConfig = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
            AppSettingsSection section = (libConfig.GetSection("appSettings") as AppSettingsSection);
            Console.WriteLine(section.Settings[name].Value);


            var value = section.Settings[name].Value;
            if (typeof(T).IsEnum)
                    return (T)Enum.Parse(typeof(T), value);
                return (T)Convert.ChangeType(value, typeof(T));
        }

        public static string ConnectionStringSettings()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            return connectionString;
        }




    }
}
